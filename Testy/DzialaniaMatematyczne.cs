using System;

namespace Testy
{
    public static class DzialaniaMatematyczne
    {
        public static int Maksimum(int[] a)
        {
            if (a == null)
                throw new NullReferenceException("nie ma a");

             int max = a[0];
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }

        public static double Srednia(int[] a)
        {
            int suma = 0;
            for(int i=0; i<a.Length; i++)
            {
                suma += a[i];
            }
            return (double)suma / a.Length;
        }
    }
}
