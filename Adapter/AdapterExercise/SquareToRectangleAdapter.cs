namespace Adapter.AdapterExercise;

public class SquareToRectangleAdapter : IRectangle
{
    public SquareToRectangleAdapter(Square square)
    {
        Width = Height = square.Side;
    }

    public int Width { get; }
    public int Height { get; }
}