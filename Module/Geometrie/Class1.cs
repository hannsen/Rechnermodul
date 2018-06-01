using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class Geometrie: RechnermodulBibliothek.AbstractModule
    {
        public Geometrie()
        {
            this.setName("Geometrie");
            this.addFunction("Dreieck", "", new DreieckFunction());
            this.addFunction("Kreis", "", new KreisFunction());
            this.addFunction("Paralleologramm", "", new ParallelogrammFunction());
        }
    }

    public class DreieckFunction: RechnermodulBibliothek.FunctionInterface
    {
        void RechnermodulBibliothek.FunctionInterface.buildUI(RechnermodulBibliothek.UIBuilderInterface builder)
        {
            builder.addStringArrayInput("grundseite", "Grundseite", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));
            builder.addStringArrayInput("hoehe", "Höhe", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));
        }

        string RechnermodulBibliothek.FunctionInterface.calculate(RechnermodulBibliothek.UserDataInterface data)
        {
            return "";

        }
    }

    public class KreisFunction: RechnermodulBibliothek.FunctionInterface
    {
        void RechnermodulBibliothek.FunctionInterface.buildUI(RechnermodulBibliothek.UIBuilderInterface builder)
        {
            builder.addStringArrayInput("radius", "Radius", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));
        }

        string RechnermodulBibliothek.FunctionInterface.calculate(RechnermodulBibliothek.UserDataInterface data)
        {
            return "";

        }
    }

    public class ParallelogrammFunction: RechnermodulBibliothek.FunctionInterface
    {
        void RechnermodulBibliothek.FunctionInterface.buildUI(RechnermodulBibliothek.UIBuilderInterface builder)
        {
            builder.addStringArrayInput("a", "Seite a", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));
            builder.addStringArrayInput("ha", "Höhe auf a", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));
            builder.addStringArrayInput("b", "Seite b", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));
        }

        string RechnermodulBibliothek.FunctionInterface.calculate(RechnermodulBibliothek.UserDataInterface data)
        {
            return "";
        }
    }
}
