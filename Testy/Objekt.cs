using System;
using System.Collections.Generic;
using System.Text;

namespace Testy
{
    public class Objekt
    {
        private int[] _a;

        public Objekt(int[] a)
        {
            _a = a;
        }
        public int Maksimum()
        {
            if (_a == null)
                throw new NullReferenceException("nie ma a");

            int max = _a[0];
            for(int i=0; i<_a.Length; i++)
            {
                if (_a[i] > max)
                    max = _a[i];
            }
            return max;
        }

    }
}
