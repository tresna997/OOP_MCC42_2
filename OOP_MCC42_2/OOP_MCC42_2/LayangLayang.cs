using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42_2
{
    public class LayangLayang : Persegi
    {
        public double hasil5 = 0.0;

        public override double LuasBangunan(double angka1, double angka2)
        {
            hasil5 = (base.LuasBangunan(angka1, angka2)) / 2;
            return hasil5;
        }
    }
}
