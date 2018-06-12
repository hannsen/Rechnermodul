using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematischesModul
{
    public class MathematischesModul : RechnermodulBibliothek.AbstractModule
    {
        public MathematischesModul()
        {
            this.setName("Mathematisches Modul");
            this.addFunction("Fakultät", "", new Fakultät());
            this.addFunction("QuadratWurzel", "", new QuadratWurzel());
            this.addFunction("Potenz", "", new Potenz());
            this.addFunction("Primzahlen zwischen Grenzwerten", "", new PrimzahlenZwischenGrenzwerten());
            this.addFunction("Umwandlung Dezimalbruch", "", new UmwandlungDezimalbruch());
        }
    }

    public class Fakultät : RechnermodulBibliothek.FunctionInterface
    {
        void RechnermodulBibliothek.FunctionInterface.buildUI(RechnermodulBibliothek.UIBuilderInterface builder)
        {
            builder.addStringInput("n", "Zahl", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));
        }

        string RechnermodulBibliothek.FunctionInterface.calculate(RechnermodulBibliothek.UserDataInterface data)
        {
            string n = data.getStringValue("n");

            return "";

        }
    }

    public class QuadratWurzel : RechnermodulBibliothek.FunctionInterface
    {
        void RechnermodulBibliothek.FunctionInterface.buildUI(RechnermodulBibliothek.UIBuilderInterface builder)
        {
            builder.addStringInput("n", "Zahl", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));
        }

        string RechnermodulBibliothek.FunctionInterface.calculate(RechnermodulBibliothek.UserDataInterface data)
        {
            string n = data.getStringValue("n");

            return "";
        }
    }

    public class Potenz : RechnermodulBibliothek.FunctionInterface
    {
        void RechnermodulBibliothek.FunctionInterface.buildUI(RechnermodulBibliothek.UIBuilderInterface builder)
        {
            builder.addStringInput("n", "Zahl", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));
            builder.addStringInput("e", "Exponent", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));

        }

        string RechnermodulBibliothek.FunctionInterface.calculate(RechnermodulBibliothek.UserDataInterface data)
        {
            string n = data.getStringValue("n");
            string e = data.getStringValue("e");

            return "";
        }
    }

    public class PrimzahlenZwischenGrenzwerten : RechnermodulBibliothek.FunctionInterface
    {
        void RechnermodulBibliothek.FunctionInterface.buildUI(RechnermodulBibliothek.UIBuilderInterface builder)
        {
            builder.addStringInput("u", "Untere Grenze", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));
            builder.addStringInput("o", "Obere Grenze", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));
        }

        string RechnermodulBibliothek.FunctionInterface.calculate(RechnermodulBibliothek.UserDataInterface data)
        {
            string u = data.getStringValue("u");
            string o = data.getStringValue("o");

            return "";
        }
    }

    public class UmwandlungDezimalbruch : RechnermodulBibliothek.FunctionInterface
    {
        void RechnermodulBibliothek.FunctionInterface.buildUI(RechnermodulBibliothek.UIBuilderInterface builder)
        {
            builder.addStringInput("n", "Nenner", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));
            builder.addStringInput("z", "Zähler", (new RechnermodulBibliothek.ModifierChain(RechnermodulBibliothek.Modifiers.NotEmptyModifier)).Add(RechnermodulBibliothek.Modifiers.DoubleModifier));
        }

        string RechnermodulBibliothek.FunctionInterface.calculate(RechnermodulBibliothek.UserDataInterface data)
        {
            string n = data.getStringValue("n");
            string z = data.getStringValue("z");

            return "";
        }
    }
}
