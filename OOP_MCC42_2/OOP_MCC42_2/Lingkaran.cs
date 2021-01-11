using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42_2
{
    public class Lingkaran : Persegi
    {
        public double hasil3 = 0.0;

        public override double Luas(double angka1)
        {
            hasil3 = 3.14 * base.Luas(angka1);
            return hasil3;
        }
    }
}
