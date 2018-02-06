using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.IO;
using RechnermodulBibliothek;

namespace Rechnermodul
{
    public partial class rechnermodul : Form
    {
        private List<RechnermodulBibliothek.ModulInterface> modules = new List<RechnermodulBibliothek.ModulInterface>(); 

        public rechnermodul()
        {
            InitializeComponent();
        }

        private void rechnermodul_Load(object sender, EventArgs e)
        {
            string[] modulesToLoad = new string[] {
                @"D:\RechnerModul\Module\DummyModul\obj\Debug\DummyModul.dll"
            };

            foreach (string dllPath in modulesToLoad) {
                var DLL = Assembly.LoadFile(@"D:\RechnerModul\Module\DummyModul\obj\Debug\DummyModul.dll");
                RechnermodulBibliothek.ModulInterface modul = null;

                foreach (Type type in DLL.GetExportedTypes()) {

                    modul = Activator.CreateInstance(type) as RechnermodulBibliothek.ModulInterface;

                    if (modul != null) {
                        continue;
                    }
                }

                if (modul == null)
                {
                    // COuld not load
                }
                else
                {
                    Console.Write(modul.getFriendlyName());
                    this.modules.Add(modul);
                }


            }
        }
    }
}
