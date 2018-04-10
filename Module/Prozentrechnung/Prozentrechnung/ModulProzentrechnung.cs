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

    public class ProzentSatzFnc : FunctionInterface
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

            String resStr = "(100 / @GW@) * @PW@";

            grundWert = Convert.ToDouble(data.getStringValue("baseVal"));
            prozentWert = Convert.ToDouble(data.getStringValue("percentVal"));

            double res = (100 / grundWert) * prozentWert;

            resStr = resStr.Replace("@GW@", grundWert.ToString()).Replace("@PW@", prozentWert.ToString()) + " = " + String.Format("{0:f}", res) + " %";

            return resStr;

        }

    }

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


            resStr = resStr.Replace("@BRUTTO@", grundWert.ToString()).Replace("@MWST@", mwst.ToString()) + " = " + String.Format("{0:f}", res);

            return resStr;
        }

    }

    public class BruttoAusNettoFnc : FunctionInterface
    {

        void RechnermodulBibliothek.FunctionInterface.buildUI(UIBuilderInterface builder)
        {

            RechnermodulBibliothek.CheckCallback checkDoubleInputDelegate = new RechnermodulBibliothek.CheckCallback((new CheckCallbackLib()).checkDoubleInput);

            builder.addStringInput("baseVal", "Nettowert für die Rechnung", checkDoubleInputDelegate);

        }

        string FunctionInterface.calculate(UserDataInterface data)
        {

            double grundWert;

            String resStr = "(@NETTO@ * @MWST@) + @NETTO@";

            grundWert = Convert.ToDouble(data.getStringValue("baseVal"));

            double mwst = 0.19;

            double res = (grundWert * mwst) + grundWert;

            resStr = resStr.Replace("@NETTO@", grundWert.ToString()).Replace("@MWST@", mwst.ToString()) + " = " + String.Format("{0:f}", res);

            return resStr;

        }

    }

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
