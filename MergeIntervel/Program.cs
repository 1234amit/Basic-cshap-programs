using MergeIntervel;

MergeIntervelSolution mergeIntervelSolution = new MergeIntervelSolution();

int[][] intervals1 = new int[][]
      {
            new int[] { 1, 3 },
            new int[] { 2, 6 },
            new int[] { 8, 10 },
            new int[] { 15, 18 }
      };

var result1 = mergeIntervelSolution.Merge(intervals1);
mergeIntervelSolution.PrintMergedIntervals(result1);
