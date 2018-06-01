using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchulModul
{
    public class SchulModul : RechnermodulBibliothek.AbstractModule
    {
        public SchulModul()
        {
            this.setName("Schulmodul");
            this.addFunction("Notendsurchschnitt", "", new NotenDurchschnitt());
        }
    }

    public class NotenDurchschnitt : RechnermodulBibliothek.FunctionInterface
    {
        void RechnermodulBibliothek.FunctionInterface.buildUI(RechnermodulBibliothek.UIBuilderInterface builder)
        {
            builder.addStringArrayInput("noten", "Note", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));
        }

        string RechnermodulBibliothek.FunctionInterface.calculate(RechnermodulBibliothek.UserDataInterface data)
        {
            string[] Noten = data.getStringArray("noten").ToArray();

            return "";

        }
    }
}
