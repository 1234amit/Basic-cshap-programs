using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblem
{
    public class MRotation
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;

            //swap elements at(i,j) to (j,i)
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            for(int i=0; i<n; i++)
            {
                Array.Reverse(matrix);
            }
        }

        public void printMatrix(int[][] matrix)
        {
            for(int i=0; i<matrix.Length; i++)
            {
                Console.WriteLine(string.Join("", matrix[i]));
            }
        }
    }
}
