using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnermodul
{
    class GrundrechenModul: RechnermodulBibliothek.AbstractModule
    {
        public GrundrechenModul()
        {
            this.setName("Grundrechner");
            this.setDescription("");

            this.addFunction("Grundrechner", "", new GrundrechenFunction());
        }
    }

    public class GrundrechenFunction: RechnermodulBibliothek.FunctionInterface
    {
        void RechnermodulBibliothek.FunctionInterface.buildUI(RechnermodulBibliothek.UIBuilderInterface builder)
        {
            RechnermodulBibliothek.ModifierChain mc = new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier);
            builder.addStringInput("infix", "Eingabe", mc);

        }

        string RechnermodulBibliothek.FunctionInterface.calculate(RechnermodulBibliothek.UserDataInterface data)
        {
            return data.getStringValue("infix") + " = " + RechnermodulBibliothek.Grundrechner.calculate(data.getStringValue("infix"));

        }

    }
}
