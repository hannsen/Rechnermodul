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
            Console.Write(File.Exists(MODULE_CONFIG_PATH).ToString() + "\n");

            this.modules = this.loadModules(this.getModulPaths());
            
            foreach (ModulInterface modul in this.modules)
            {
                lb_Module.Items.Add(modul.getFriendlyName());
            }       
        }

        private void lb_Module_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lb_Module.SelectedIndex;

            if (index >= modules.Length)
            {
                return;
            }

            ModulInterface modul = this.modules[index];

            foreach (FunctionDescriptionInterface fd in modul.getFunctionDescriptions())
            {
                lb_Functions.Items.Add(fd.getName());
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            ModulInterface modul = this.modules[lb_Module.SelectedIndex];

            FunctionInterface function = modul.getFunctions()[lb_Functions.SelectedIndex];

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

        }

        void RechnermodulBibliothek.UIBuilderInterface.addStringInput(string key, string description, CheckCallback validator)
        {

        }

        UIElement[] RechnermodulBibliothek.UIBuilderInterface.getUIElements()
        {
            return elements.ToArray<UIElement>();
        }
    }
}
