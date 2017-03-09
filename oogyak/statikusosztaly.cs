using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oogyak
{
    static class statikusosztaly
    {
        //public int i; // statikus osztályban nem lehet objektumhoz kötődő adattag
        //public void f15() { } // statikus osztályban nem lehet objektumhoz kötődő metódus

        public static int z;
        public static void f16()
        {
            z = 5;
        }

        static statikusosztaly()
        {
            z = 20;
        }
    }
}
