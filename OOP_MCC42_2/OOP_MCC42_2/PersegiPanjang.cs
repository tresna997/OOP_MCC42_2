using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42_2
{
    public class PersegiPanjang : Persegi
    {
        public double hasil2 = 0.0;

        public override double LuasBangunan(double angka1, double angka2)
        {
            hasil2 = base.LuasBangunan(angka1, angka2);
            return hasil2;
        }
    }
}
