using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control {
    class Students : IStudy {
        public string Name;
        public Students(string name) {
            Name = name;
        }
        public void study( ) {
            Console.WriteLine("Учусь.");
        }
    }
}
