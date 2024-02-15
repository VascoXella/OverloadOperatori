using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverloadOperatori.Properties
{
    internal class Fraction
    {
        public int n { get; set; }
        public int d { get; set; }

        public Fraction(int n, int d)
        {
            Semplf(n, d, out int num, out int den);
            n = num;
            d = den;

            if (d < 0)
            {
                n = -n;
                d = -d;
            }
        }

        public void Semplf(int num, int den, out int n, out int d)
        {
            int mcd = MCD(num, den);
            n = num / mcd;
            d = den / mcd;
            return;
        }

        public int MCD(int n1, int n2)  //tra 4 e 6 = 2
        {
            while (n1 != n2)
            {
                if (n1 < n2)
                {
                    int n3 = n1;
                    n1 = n2;
                    n2 = n3;
                }

                n1 = n1 - n2;
            }
            {
                return n1;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} / {1}", n, d);
        }   

        public bool Equals(Fraction f)
        {
            if (n == f.n && d == f.d)
                return true;

            else
                return false;
        }

        public static bool TryParse(string s, out Fraction v)
        {
            try
            {
                string[] parts = s.Split('/');
                v = new Fraction(int.Parse(parts[0]), int.Parse(parts[1]));
                return true;
            }
            catch
            {
                MessageBox.Show("ERRORE");
                v = null;
                return false;
            }
        }

    }
}   


