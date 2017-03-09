using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oogyak
{
    // öröklődés/leszármaztatás(inheritance)  ... specializálás(specialisation)
    // "xyz" ősosztály(base class/super class/parent class/ancestor class/base type)
    // "abc" leszármazott (alosztály=sub class/child class/derived class/inherited class)/type
    abstract class abc : xyz
    { 
       public void lathatosagiproba()
        {
            // a++;  basec privát adattagja
            b++; // mert protected
            c++; // mert public

            P2 = 6; // mert P2 property setter-e protected láthatóságú
        }

        public override void f3() // xyz::f3 absztrakt metódusát override-oltuk / megvalósítottuk / realizáltuk
        {           
        }

       
    }
}
