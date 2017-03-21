using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control {
    class Prepod : Students {
        public Prepod(string name) : base(name) { }
        new public void study( ) {
            base.study( );
            Console.WriteLine("Учу.");
        }
    }
}
