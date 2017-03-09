using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oogyak
{

    sealed class klm
    {
        int m1, m2;


        // konstruktor példák (constructor, ctor)
        // konstruktor neve megegyezik az osztály nevével
        // ha nincs paramétere alapértelmezett kontruktronak nevezzük (default constructor)

        // default constructor
        public klm() : this(1.0f)
        {
        }

        public klm(int p) : this(p, 10)
        {
        }

        // master constructor
        public klm(int p1, int p2)
        {
            m1 = p1;
            m2 = p2;
        }

        // master constructor
        public klm(float p1, float p2=10.0f) // new klm(5.0f) , new klm(5.0f,6.0f)
        {
        }



        // destruktor (desctructor, dtor)
        /*~klm()
        {

        }*/




    }
}
