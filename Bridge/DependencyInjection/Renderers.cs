namespace Bridge.DependencyInjection;

using static Console;

public interface IRenderer
{
    void RenderCircle(float radius);
}

public class VectorRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        WriteLine($"Drawing vector for circle with radius {radius}");
    }
}

public class RasterRenderer : IRenderer
{
    public void RenderCircle(float radius)
    {
        WriteLine($"Drawing pixels for circle with radius {radius}");
    }
}