using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RechnermodulBibliothek;

namespace Prozentrechnung
{
    public class ModulProzentrechnung : AbstractModule
    {

        public ModulProzentrechnung()
        {

            this.setName("Prozentrechnung");
            this.setDescription("");

            this.addFunction("%dazu", "", new ProzentDazuFnc());
            this.addFunction("%weg", "", new ProzentWegFnc());
            this.addFunction("%davon", "", new ProzentDavonFnc());
            this.addFunction("%Satz", "", new ProzentSatzFnc());
            this.addFunction("Netto aus Brutto", "", new NettoAusBruttoFnc());
            this.addFunction("Brutto aus Netto", "", new BruttoAusNettoFnc());

        }

    }

    private class ProzentDazuFnc : FunctionInterface
    {

        void RechnermodulBibliothek.FunctionInterface.buildUI(UIBuilderInterface builder)
        {

            RechnermodulBibliothek.CheckCallback checkDoubleInputDelegate = new RechnermodulBibliothek.CheckCallback(CheckCallbackLib.Instance.checkDoubleInput);

            builder.addStringInput("baseVal", "Grundwert für die Rechnung", checkDoubleInputDelegate);
            builder.addStringInput("percentVal", "Prozentwert für die Rechnung", checkDoubleInputDelegate);

        }

        string FunctionInterface.calculate(UserDataInterface data)
        {
            double grundWert;
            double prozentWert;

            if(!(Double.TryParse(data.getStringValue("baseVal"), out grundWert) &&
                Double.TryParse(data.getStringValue("precentVal"), out prozentWert))) {

                    return "Eingaben nicht gültig!";
            }

            double addVal = grundWert * (prozentWert / 100);

            return grundWert + " + (" + prozentWert / 100 + " * " + grundWert + ") = " + (grundWert + addVal).ToString();

        }

    }

    private class ProzentWegFnc : FunctionInterface
    {

        void RechnermodulBibliothek.FunctionInterface.buildUI(UIBuilderInterface builder)
        {

            RechnermodulBibliothek.CheckCallback checkDoubleInputDelegate = new RechnermodulBibliothek.CheckCallback(CheckCallbackLib.Instance.checkDoubleInput);

            builder.addStringInput("baseVal", "Grundwert für die Rechnung", checkDoubleInputDelegate);
            builder.addStringInput("percentVal", "Prozentwert für die Rechnung", checkDoubleInputDelegate);

        }

        string FunctionInterface.calculate(UserDataInterface data)
        {
            double grundWert;
            double prozentWert;

            if (!(Double.TryParse(data.getStringValue("baseVal"), out grundWert) &&
                Double.TryParse(data.getStringValue("precentVal"), out prozentWert)))
            {

                return "Eingaben nicht gültig!";
            }

            double subVal = grundWert * (prozentWert / 100);

            return grundWert + " - (" + prozentWert / 100 + " * " + grundWert + ") = " + (grundWert - subVal).ToString();

        }

    }

    private class ProzentDavonFnc : FunctionInterface
    {

        void RechnermodulBibliothek.FunctionInterface.buildUI(UIBuilderInterface builder)
        {

            RechnermodulBibliothek.CheckCallback checkDoubleInputDelegate = new RechnermodulBibliothek.CheckCallback(CheckCallbackLib.Instance.checkDoubleInput);

            builder.addStringInput("baseVal", "Grundwert für die Rechnung", checkDoubleInputDelegate);
            builder.addStringInput("percentVal", "Prozentwert für die Rechnung", checkDoubleInputDelegate);

        }

        string FunctionInterface.calculate(UserDataInterface data)
        {
            double grundWert;
            double prozentWert;

            if (!(Double.TryParse(data.getStringValue("baseVal"), out grundWert) &&
                Double.TryParse(data.getStringValue("precentVal"), out prozentWert)))
            {

                return "Eingaben nicht gültig!";
            }

            double res = grundWert * (prozentWert / 100);

            return (prozentWert / 100) + " * " + grundWert + " = " + res;

        }

    }

    private class ProzentSatzFnc : FunctionInterface
    {

    }

    private class NettoAusBruttoFnc : FunctionInterface
    {

        void RechnermodulBibliothek.FunctionInterface.buildUI(UIBuilderInterface builder)
        {

            RechnermodulBibliothek.CheckCallback checkDoubleInputDelegate = new RechnermodulBibliothek.CheckCallback(CheckCallbackLib.Instance.checkDoubleInput);

            builder.addStringInput("baseVal", "Bruttowert für die Rechnung", checkDoubleInputDelegate);

        }

        string FunctionInterface.calculate(UserDataInterface data)
        {
            double grundWert;

            if (!Double.TryParse(data.getStringValue("baseVal"), out grundWert))
            {
                return "Eingaben nicht gültig!";
            }

            double mwst = 0.19;
            double factor = 1 / (1 + mwst);

            double res = grundWert * factor;

            return "";

        }

    }

    private class BruttoAusNettoFnc : FunctionInterface
    {
        
    }

    public class CheckCallbackLib
    {

        private static volatile CheckCallbackLib INSTANCE;

        private CheckCallbackLib() { }

        public static CheckCallbackLib Instance
        {

            get
            {
                if (INSTANCE == null)
                    INSTANCE = new CheckCallbackLib();

                return INSTANCE;
            }           

        }

        public string checkDoubleInput(string input)
        {
            double res;

            if (Double.TryParse(input, out res))
            {
                return null;
            }

            return "Eingabe: " + input + " ist nicht zulässig! (Eingabe muss den Anforderungen einer Gleitkommazahl genügen!)";
        }
    }
}
