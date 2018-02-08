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

            RechnermodulBibliothek.CheckCallback checkDoubleInputDelegate = new RechnermodulBibliothek.CheckCallback(checkDoubleInput);

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

            return (grundWert + addVal).ToString();

        }

        string checkDoubleInput(string input)
        {
            double res;

            if(Double.TryParse(input, out res)) 
            {
                return null;
            }

            return "Eingabe: " + input + " ist nicht zulässig! (Eingabe muss den Anforderungen einer Gleitkommazahl genügen!)";
        }




    }

    private class ProzentWegFnc : FunctionInterface
    {

    }

    private class ProzentDavonFnc : FunctionInterface
    {

    }

    private class ProzentSatzFnc : FunctionInterface
    {

    }

    private class NettoAusBruttoFnc : FunctionInterface
    {

    }

    private class BruttoAusNettoFnc : FunctionInterface
    {

    }
}
