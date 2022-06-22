using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC
{
    public class Quickselect
    {
        public static int /* valeur pas index */ Select(Func<int[], int, int, int, int> partition, int[] array, int first, int last, int target)
        {
            if (first >= last || first < 0) return array[last];

            int valeurPivot = array[(first + last) / 2];

            int indexPivot = partition(array, first, last, /* Valeur, pas index */ valeurPivot);
            if (target > indexPivot)
            {
                return Select(partition, array, indexPivot, last, target);
            }
            else
            {
                return Select(partition, array, first, indexPivot, target);
            }
        }
    }
}
