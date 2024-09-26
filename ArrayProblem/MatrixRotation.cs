using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblem
{
    public class MatrixRotation
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;

            //swap element (i, j) to (j, i)
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            //reverse each now
            for(int i=0; i<n; i++)
            {
                Array.Reverse(matrix);
            }
        }

        public void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
