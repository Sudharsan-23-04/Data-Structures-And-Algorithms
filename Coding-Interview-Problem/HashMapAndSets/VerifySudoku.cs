namespace Coding_Interview_Problem.HashMapAndSets
{
    public static partial class HashMapAndSets
    {
        public static bool IsValidSudoku(char[][] board)
        {
            var rowHashSet = Enumerable.Range(0, 9)
                                       .Select(_ => new HashSet<char>())
                                       .ToList();

            var colHashSet = Enumerable.Range(0, 9)
                                       .Select(_ => new HashSet<char>())
                                       .ToList();

            var gridHashSet = Enumerable.Range(0, 3)
                                        .Select(_ => Enumerable.Range(0, 3)
                                                               .Select(__ => new HashSet<char>())
                                                               .ToList())
                                        .ToList();

            for (int i = 0; i < 9; i++) 
            {
                for (int j = 0; j < 9; j++)
                {
                    char c = board[i][j];
                    if (c == '.') continue;

                    if (rowHashSet[i].Contains(c) ||
                        colHashSet[j].Contains(c) ||
                        gridHashSet[i / 3][j / 3].Contains(c))
                    {
                        return false;
                    }

                    rowHashSet[i].Add(c);
                    colHashSet[j].Add(c);
                    gridHashSet[i / 3][j / 3].Add(c);
                }
            }

            return true;
        }
    }

}
