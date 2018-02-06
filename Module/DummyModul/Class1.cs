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
        }
    }
}
