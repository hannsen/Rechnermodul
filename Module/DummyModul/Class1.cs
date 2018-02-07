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
        void RechnermodulBibliothek.FunctionInterface.buildUI(UIBuilderInterface builder)
        {

        }

        string FunctionInterface.calculate(UserDataInterface data)
        {
            return "test";
        }
    }
}
