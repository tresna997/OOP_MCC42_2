using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42_2
{
    public class Persegi : BangunDatar
    {
        double hasil1 = 0.0;
        double hasil2 = 0.0;

        public virtual double Luas(double angka1)
        {
            hasil1 = angka1 * angka1;
            return hasil1;
        }

        public virtual double LuasBangunan(double angka1, double angka2)
        {
            hasil2 = angka1 * angka2;
            return hasil2;
        }
    }
}
