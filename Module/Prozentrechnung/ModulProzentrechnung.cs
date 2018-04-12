using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RechnermodulBibliothek;

namespace Prozentrechnung
{
    public class ModulProzentrechnung : RechnermodulBibliothek.AbstractModule
    {

        public ModulProzentrechnung()
        {

            this.setName("Prozentrechnung");
            this.setDescription("");

            this.addFunction("%dazu", "", new ProzentDazuFnc());
            this.addFunction("%weg", "", new ProzentWegFnc());
            this.addFunction("%davon", "", new ProzentDavonFnc());
            //this.addFunction("%Satz", "", new ProzentSatzFnc());
            this.addFunction("Netto aus Brutto", "", new NettoAusBruttoFnc());
            //this.addFunction("Brutto aus Netto", "", new BruttoAusNettoFnc());

        }

    }

    public class ProzentDazuFnc : FunctionInterface
    {

        void RechnermodulBibliothek.FunctionInterface.buildUI(UIBuilderInterface builder)
        {
            
            RechnermodulBibliothek.CheckCallback checkDoubleInputDelegate = new RechnermodulBibliothek.CheckCallback((new CheckCallbackLib()).checkDoubleInput);

            builder.addStringInput("baseVal", "Grundwert für die Rechnung", checkDoubleInputDelegate);
            builder.addStringInput("percentVal", "Prozentwert für die Rechnung", checkDoubleInputDelegate);

        }

        string FunctionInterface.calculate(UserDataInterface data)
        {
            double grundWert;
            double prozentWert;

            grundWert = Convert.ToDouble(data.getStringValue("baseVal"));
            prozentWert = Convert.ToDouble(data.getStringValue("percentVal"));

            double addVal = grundWert * (prozentWert / 100);

            return grundWert + " + (" + prozentWert / 100 + " * " + grundWert + ") = " + (grundWert + addVal).ToString();

        }

    }

    public class ProzentWegFnc : FunctionInterface
    {

        void RechnermodulBibliothek.FunctionInterface.buildUI(UIBuilderInterface builder)
        {

            RechnermodulBibliothek.CheckCallback checkDoubleInputDelegate = new RechnermodulBibliothek.CheckCallback((new CheckCallbackLib()).checkDoubleInput);

            builder.addStringInput("baseVal", "Grundwert für die Rechnung", checkDoubleInputDelegate);
            builder.addStringInput("percentVal", "Prozentwert für die Rechnung", checkDoubleInputDelegate);

        }

        string FunctionInterface.calculate(UserDataInterface data)
        {
            double grundWert;
            double prozentWert;

            grundWert = Convert.ToDouble(data.getStringValue("baseVal"));
            prozentWert = Convert.ToDouble(data.getStringValue("percentVal"));

            double subVal = grundWert * (prozentWert / 100);

            return grundWert + " - (" + prozentWert / 100 + " * " + grundWert + ") = " + (grundWert - subVal).ToString();

        }

    }

    public class ProzentDavonFnc : FunctionInterface
    {

        void RechnermodulBibliothek.FunctionInterface.buildUI(UIBuilderInterface builder)
        {

            RechnermodulBibliothek.CheckCallback checkDoubleInputDelegate = new RechnermodulBibliothek.CheckCallback((new CheckCallbackLib()).checkDoubleInput);

            builder.addStringInput("baseVal", "Grundwert für die Rechnung", checkDoubleInputDelegate);
            builder.addStringInput("percentVal", "Prozentwert für die Rechnung", checkDoubleInputDelegate);

        }

        string FunctionInterface.calculate(UserDataInterface data)
        {
            double grundWert;
            double prozentWert;

            grundWert = Convert.ToDouble(data.getStringValue("baseVal"));
            prozentWert = Convert.ToDouble(data.getStringValue("percentVal"));

            double res = grundWert * (prozentWert / 100);

            return (prozentWert / 100) + " * " + grundWert + " = " + res;

        }

    }

    //public class ProzentSatzFnc : FunctionInterface
    //{

    //}

    public class NettoAusBruttoFnc : FunctionInterface
    {

        void RechnermodulBibliothek.FunctionInterface.buildUI(UIBuilderInterface builder)
        {

            RechnermodulBibliothek.CheckCallback checkDoubleInputDelegate = new RechnermodulBibliothek.CheckCallback((new CheckCallbackLib()).checkDoubleInput);

            builder.addStringInput("baseVal", "Bruttowert für die Rechnung", checkDoubleInputDelegate);

        }

        string FunctionInterface.calculate(UserDataInterface data)
        {
            double grundWert;

            String resStr = "@BRUTTO@ / (1 + @MWST@)";

            grundWert = Convert.ToDouble(data.getStringValue("baseVal"));

            double mwst = 0.19;

            double res = grundWert / (1 + mwst);

            return res.ToString();

        }

    }

    //public class BruttoAusNettoFnc : FunctionInterface
    //{
        
    //}

    public class CheckCallbackLib
    {

        //private static volatile CheckCallbackLib INSTANCE;

        //private CheckCallbackLib() { }

        //public static CheckCallbackLib Instance
        //{

        //    get
        //    {
        //        if (INSTANCE == null)
        //            INSTANCE = new CheckCallbackLib();

        //        return INSTANCE;
        //    }           

        //}

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
