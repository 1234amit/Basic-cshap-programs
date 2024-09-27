using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeIntervel
{
    public class MergeIntervelSolution
    {
        public int[][] Merge(int[][] intervels)
        {
            //sort intervel based on the start value
            Array.Sort(intervels, (a, b) => a[0].CompareTo(b[0]));
            //result list to store merge intervels
            List<int[]> merged = new List<int[]>();
            //sart with first intervel

            int[] currentIntervel = intervels[0];
            merged.Add(currentIntervel);

            foreach (int[] intervel in intervels)
            {
                int currentEnd = currentIntervel[1];
                int nextStart = intervel[0];
                int nextend = intervel[1];

                //if the current intervel overlaps with next intervel,merge them
                if(currentEnd >= nextStart)
                {
                    currentIntervel[1] = Math.Max(currentEnd, nextend);
                }
                else
                {
                    //no overlap and the next intervel to the list
                    currentIntervel = intervel;
                    merged.Add(currentIntervel);
                }
            }

            return merged.ToArray();
        }


        private static string PrintIntervals(int[][] intervals)
        {
            List<string> intervalsList = new List<string>();
            foreach (var interval in intervals)
            {
                intervalsList.Add($"[{interval[0]},{interval[1]}]");
            }
            return string.Join(", ", intervalsList);
        }

        public void PrintMergedIntervals(int[][] intervals)
        {
            Console.WriteLine("Merged intervals: " + PrintIntervals(intervals));
        }
    }
}
