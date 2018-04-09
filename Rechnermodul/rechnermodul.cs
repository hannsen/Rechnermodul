using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Reflection;
using System.IO;
using RechnermodulBibliothek;

namespace Rechnermodul
{
    public partial class rechnermodul : Form
    {
        private class MyMenuItem : ToolStripMenuItem
        {
            public int moduleId;
            public int functionId;
        }

        private static string APP_PATH = Path.GetDirectoryName(Application.ExecutablePath);
        private RechnermodulBibliothek.ModulInterface[] modules;
        private static string MODULE_CONFIG_PATH = APP_PATH + "/../../MeineModule.txt";

        public rechnermodul()
        {
            InitializeComponent();
        }

        private string[] getModulPaths()
        {
            string[] paths = File.ReadAllLines(MODULE_CONFIG_PATH);

            for (int i=0; i<paths.Length; i++)
            {
                paths[i] = APP_PATH + "/" + paths[i];
            }

            return paths;
        }

        private RechnermodulBibliothek.ModulInterface[] loadModules(string[] modulePaths)
        {
            List<RechnermodulBibliothek.ModulInterface> modules = new List<RechnermodulBibliothek.ModulInterface>();

            foreach (string dllPath in modulePaths)
            {
                if (!File.Exists(dllPath))
                {
                    Console.Write("Could not load file " + dllPath);

                    continue;
                }

                var DLL = Assembly.LoadFile(dllPath);
                foreach (Type type in DLL.GetExportedTypes())
                {

                    RechnermodulBibliothek.ModulInterface modul = Activator.CreateInstance(type) as RechnermodulBibliothek.ModulInterface;

                    if (modul != null)
                    {
                        modules.Add(modul);
                    }
                }
            }

            return modules.ToArray<RechnermodulBibliothek.ModulInterface>();
        }

        private void rechnermodul_Load(object sender, EventArgs e)
        {

            Console.Write(APP_PATH + "\n");

            this.modules = this.loadModules(this.getModulPaths());
            
            for (int mId = 0; mId<this.modules.Length; mId++)
            {
                RechnermodulBibliothek.ModulInterface modul = this.modules[mId];
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = modul.getFriendlyName();

                ms_module.Items.Add(item);

                FunctionDescriptionInterface[] functions = modul.getFunctionDescriptions();
                for (int fId = 0; fId < functions.Length; fId++ )
                {
                    FunctionDescriptionInterface fd = functions[fId];
                    MyMenuItem sub_item = new MyMenuItem();
                    sub_item.Text = fd.getName();
                    sub_item.functionId = fId;
                    sub_item.moduleId = mId;
                    sub_item.Click += new EventHandler(ms_function_click);
                    item.DropDownItems.Add(sub_item);
                }
            }       
        }
        private void ms_function_click(object sender, EventArgs e)
        {
            MyMenuItem item = sender as MyMenuItem;

            ModulInterface modul = this.modules[item.moduleId];

            FunctionInterface function = modul.getFunctions()[item.functionId];

            UIBuilderInterface builder = new UIBuilder();

            function.buildUI(builder);

            var uem = new UniversellesEingabeModul.universelleseingabemodul();
            uem.buildUi(builder);
            uem.ShowDialog();

            lb_Ergebnis.Items.Add(function.calculate(uem.getData()));

        }
    }

    public class UIBuilder: RechnermodulBibliothek.UIBuilderInterface
    {
        private List<UIElement> elements = new List<UIElement>();

        void RechnermodulBibliothek.UIBuilderInterface.addStringArrayInput(string key, string description, CheckCallback validator)
        {
            UIElement element = new UIElement(UIElement.TYPE_ARRAY, key, description, validator);

            this.elements.Add(element);
        }

        void RechnermodulBibliothek.UIBuilderInterface.addStringInput(string key, string description, CheckCallback validator)
        {
            UIElement element = new UIElement(UIElement.TYPE_SINGLE, key, description, validator);

            this.elements.Add(element);
        }

        UIElement[] RechnermodulBibliothek.UIBuilderInterface.getUIElements()
        {
            return elements.ToArray<UIElement>();
        }
    }
}
