public class ConsoleDraw(int width, int height)
{
    private readonly char[,] _charMatrix = new char[height, width];
    public readonly int height = height > 0 ? height : 1;
    public readonly int width = width > 0 ? width : 1;
    private int _spaces;
    public void SetSpaces(int spaces) => _spaces = spaces;

    public void DrawMatrix()
    {
        Console.SetCursorPosition(0, 0);
        StringBuilder lines = new();
        for (int i = 0; i < height; i++)
        {
            StringBuilder line = new();
            for (int j = 0; j < width; j++)
            {
                line.Append(_charMatrix[i, j]);
                for (int k = 0; k < _spaces; k++)
                {
                    line.Append(' ');
                }
            }
            lines.AppendLine(line.ToString());
        }
        // using StreamWriter writer = new(@"F:\179\OTHER\ImageDrawTest\TextImages\test.txt");
        // writer.Write(lines);
        Console.Write(lines);
    }

    /// <summary>
    ///     set matrix char
    /// </summary>
    /// <param name="x">matrix index x</param>
    /// <param name="y">matrix index y</param>
    /// <param name="c">char</param>
    public void SetMatrix(int x, int y, char c)
    {
        _charMatrix[y, x] = c;
    }

    /// <summary>
    ///     fill line
    /// </summary>
    /// <param name="line">line index</param>
    /// <param name="c">char</param>
    public void FillMatrixLine(int line, char c)
    {
        for (int i = 0; i < width; i++)
        {
            SetMatrix(i, line, c);
        }
    }

    /// <summary>
    ///     fill column
    /// </summary>
    /// <param name="col">column index</param>
    /// <param name="c">char</param>
    public void FillMatrixCol(int col, char c)
    {
        for (int i = 0; i < width; i++)
        {
            SetMatrix(col, i, c);
        }
    }
}