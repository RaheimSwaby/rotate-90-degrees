namespace algo_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][] 
            {
                new int[]{1,2,3 },
                new int[]{4,5,6},
                new int[]{6,7,8}
            };
            Rotate(matrix);
           Print(matrix);
        }


        public static void Rotate(int[][] matrix)
        {
            int n = matrix.Length;

            for (int i = 0; i < n; i++) 
            {
                for (int j = i + 1; j < n; j++) 
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            for (int i = 0;i < n; i++) 
            {
                int left = 0;
                int right = n - 1;

                while (left < right) 
                {
                    int temp = matrix[i][left];
                    matrix[i][left] = matrix[i][right];
                    matrix[i][right] = temp;
                    left++;
                    right--;
                }
                //Array.Reverse(matrix[i]);
            }


        }
        public static void Print(int[][] matrix)
        {
            foreach(var row  in matrix) 
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}


