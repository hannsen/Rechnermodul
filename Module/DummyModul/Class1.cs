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
                return s;
            }
            throw new NutzerEingabeFehler("Ist keine Zahl");
        }

        void RechnermodulBibliothek.FunctionInterface.buildUI(UIBuilderInterface builder)
        {
            ModifierChain mc = new ModifierChain(Modifiers.NotEmptyModifier).
                Add(Modifiers.CalculateModifier);

            builder.addStringInput("s1", "Summand1", mc);
            builder.addStringInput("s2", "Summand2", mc);
            builder.addStringArrayInput("s3", "restlichen Summanden", mc);
            builder.addStringArrayInput("s4", "weitere Summanden", mc);
            builder.addStringArrayInput("s5", "mehr Summanden", mc);

        }

        string FunctionInterface.calculate(UserDataInterface data)
        {
            int res = 0;
            
            return res + data.getStringValue("s1");
        }
    }
}
