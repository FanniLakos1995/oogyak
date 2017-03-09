using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oogyak
{
    // interfész osztály (interface)
    // kódolási konvenció az interface nevére: IValami
    // "ijk" interfész leszármazik "ijkos" ős interfész osztályból
    interface ijk : ijkos
    {
        // adattagok nem szerepelhetnek az interfész osztályban
        // public int i;

        // metódusnak nem adhatunk léáthatósági korlátozást
        // a metódusnak nem lehet kifejtése mert absztrakt metódusoknak kell lenniük
        /*public void f6()
        {
        }*/

        // abstract kulcsszó sem lehet kiírva mert az az alapértelmezett
        //abstract void f7();

        void f8(); // ez egy dinamikus kötésű, public láthatóságú virtuális absztrakt metódus
    }
}
