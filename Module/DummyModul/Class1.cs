using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RechnermodulBibliothek;

namespace DummyModul
{
    public class Class1 : RechnermodulBibliothek.AbstractModule
    {
        public Class1() {
            this.setName("MeinDummyModul");
            this.setDescription("asdfgh");

            this.addFunction("MeineErsteFunktion", "", new f1());
            this.addFunction("MeineZweiteFunktion", "", new f1());
        }
    }

    public class f1 : FunctionInterface
    {
        private string intChecker(string s)
        {
            int x;
            if (int.TryParse(s, out x))
            {
                return null;
            }
            return "Fehler, ist halt keine Zahl";
        }

        void RechnermodulBibliothek.FunctionInterface.buildUI(UIBuilderInterface builder)
        {
            builder.addStringInput("s1", "Summand1", this.intChecker);
            builder.addStringArrayInput("s", "restlichen Summanden", this.intChecker);
        }

        string FunctionInterface.calculate(UserDataInterface data)
        {
            int res = 0;
            
            return res + data.getStringValue("s1");
        }
    }
}
