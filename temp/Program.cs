using System;
using System.Collections.Generic;
using System.Linq;

namespace temp
{
    internal class Program
    {
        static int binary_search(int[] A, int target)
        {
            var lo = 1;
            var hi = A.Length;
            while (lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (A[mid] == target)
                {
                    return mid + 1;
                }
                else if (A[mid] < target)
                {
                    lo = mid + 1;
                }
                else
                {
                    hi = mid - 1;
                }
            }
            return A[0];
        }

//        binary_search2(int lo, int hi, int p)
//        {
//            while (lo < hi)
//            {
//                mid = lo + (hi-lo)/2
//                if p(mid) == true:
//                hi = mid
//                else:
//                lo = mid+1
//            }
//            
//          
//            if p(lo) == false:
//            complain                // p(x) is false for all x in S!
//      
//            return lo         // lo is the least x for which p(x) is true   
//        }
            
            
        
        public static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var q = int.Parse(Console.ReadLine());
            List<int> temp = new List<int>();
            for (int i = 0; i <= q; i++)
            {
                temp.Add(int.Parse(Console.ReadLine()));
            }

            array = array.OrderBy(x => x).ToArray();
            for (int i = 0; i <= q; i++)
            {
                Console.WriteLine(binary_search(array, temp[i]));
            }
        }
    }
}