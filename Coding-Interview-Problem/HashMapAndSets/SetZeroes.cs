namespace Coding_Interview_Problem.HashMapAndSets
{
    public static partial class HashMapAndSets
    {
        public static void SetZeroes(int[][] matrix)
        {
            var rowHashSet = new HashSet<int>();
            var colHashSet = new HashSet<int>();

            for(int rowNumber = 0; rowNumber < matrix.Length; rowNumber++)
            {
                for(int colNumber = 0; colNumber < matrix[rowNumber].Length; colNumber++)
                {
                    if (matrix[rowNumber][colNumber] == 0)
                    {
                        rowHashSet.Add(rowNumber);
                        colHashSet.Add(colNumber);
                    }
                }
            }

            for (int rowNumber = 0; rowNumber < matrix.Length; rowNumber++)
            {
                for (int colNumber = 0; colNumber < matrix[rowNumber].Length; colNumber++)
                {
                    if (rowHashSet.Contains(rowNumber) || colHashSet.Contains(colNumber))
                    {
                        matrix[rowNumber][colNumber] = 0;
                    }
                }
            }
        }
    }
}
