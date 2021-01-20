using System;
using System.Collections.Generic;
using System.Text;

namespace PeraOdev
{
    class Hesapla
    {
        public int UcgenAlan(int a, int b)
        {
            return (a * b) / 2;
        }
        public int DikdortgenAlan(int a, int b)
        {
            return a * b;
        }
        public int KareAlan(int a)
        {
            return a * a;
        }
        public int DaireAlan(double yaricap)
        {
            double pi = 3.14;
            return (int)(pi * yaricap * yaricap);
        }

    }
}
