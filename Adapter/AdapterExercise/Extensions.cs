namespace Adapter.AdapterExercise;

public static class Extensions
{
    public static int Area(this IRectangle rectangle) => rectangle.Width * rectangle.Height;
}