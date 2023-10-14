namespace SandBox
{
    class SandBox
    {
        static void Main(string [] args)
        {
            int [,] matrix = new int[5, 5]
            {
                {1, 3, 2, 0, 1},
                {2, 6, 3, 1, 0},
                {8, 1, 3, 2, 4},
                {2, 3, 2, 1, 0},
                {1, 2, 1, 2, 0}
            };
            int n = 5;
            Console.WriteLine(DeterminateOfMatrix(matrix, n));
        }
        static int DeterminateOfMatrix(int [,] matrix, int n)
        {
            int det = 0;
            int[,] minor = new int[5, 5];
            for(int i = 0; i < n; i++)
            {
                Minor(matrix, minor, 0, i, 5);
            }
            foreach(int item in minor)
            {
                Console.WriteLine(item);
            }
            return det;
        }
        static void Minor(int[,] matrix, int[,]minor, int p, int q, int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(i == p || j == q)
                    {
                        continue;
                    }

                    minor[i, j] = matrix[i, j];
                }                
            }
        }

    }
}