namespace Bridge.BridgeExercise;

public interface IRenderer
{
    string WhatToRenderAs { get; }
}

public class VectorRenderer : IRenderer
{
    public string WhatToRenderAs => "lines";
}

public class RasterRenderer : IRenderer
{
    public string WhatToRenderAs => "pixels";
}