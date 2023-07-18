namespace MathAndFun;

internal class SudokuSolution
{

    internal SudokuSolution(string[] lines)
    {
        int[,] result = new int[9, 9];
        for (int y = 0; y < 9; y++)
        {
            var line = lines[y].Split(' ');
            for (int x = 0; x < 9; x++)
            {
                result[x, y] = int.Parse(line[x]);
            }
        }
        SolutionArray = result;
    }

    internal IEnumerable<List<int>> Rows
    {
        get
        {
            for (int y = 0; y < 9; y++)
            {
                var row = new List<int>();
                for (int x = 0; x < 9; x++)
                {
                    row.Add(SolutionArray[x, y]);
                }
                yield return row;
            }
        }
    }

    internal IEnumerable<List<int>> Columns
    {
        get
        {
            for (int x = 0; x < 9; x++)
            {
                var column = new List<int>();
                for (int y = 0; y < 9; y++)
                {
                    column.Add(SolutionArray[x, y]);
                }
                yield return column;
            }
        }
    }

    internal IEnumerable<List<int>> Blocks
    {
        get
        {
            for (int y = 0; y < 9; y += 3)
            {
                for (int x = 0; x < 9; x += 3)
                {
                    var block = new List<int>();
                    block.Add(SolutionArray[x + 0, y + 0]);
                    block.Add(SolutionArray[x + 1, y + 0]);
                    block.Add(SolutionArray[x + 2, y + 0]);

                    block.Add(SolutionArray[x + 0, y + 1]);
                    block.Add(SolutionArray[x + 1, y + 1]);
                    block.Add(SolutionArray[x + 2, y + 1]);

                    block.Add(SolutionArray[x + 0, y + 2]);
                    block.Add(SolutionArray[x + 1, y + 2]);
                    block.Add(SolutionArray[x + 2, y + 2]);
                    yield return block;
                }
            }
        }
    }

    internal IEnumerable<IEnumerable<int>> Diagonals => new HashSet<HashSet<int>>()
      {
        GetDiagonal(offset: 0).ToHashSet(),
        GetDiagonal(offset: 8).ToHashSet()
      };

    private IEnumerable<int> GetDiagonal(int offset)
    {
        for (int z = 0; z < 9; z++)
        {
            yield return SolutionArray[Math.Abs(offset - z), offset];
        }
    }

    private int[,] SolutionArray { get; set; }

}