using System;
using System.Collections.Generic;

namespace prak_2
{

    public class Class1
    {
        public bool CompareByOrder<T>(List<T> collection1, List<T> collection2)
        {
            if (collection1.Count != collection2.Count)
                return false;

            for (int i = 0; i < collection1.Count; i++)
            {
                if (!collection1[i].Equals(collection2[i]))
                    return false;
            }

            return true;
        }

        public bool CompareIgnoringOrder<T>(List<T> collection1, List<T> collection2)
        {
            if (collection1.Count != collection2.Count)
                return false;

            HashSet<T> set1 = new HashSet<T>(collection1);
            HashSet<T> set2 = new HashSet<T>(collection2);

            return set1.SetEquals(set2);
        }
        public double CalculatePercentage(int part, int whole)
        {
            return (double)part / whole * 100.0;
        }
    }
}
