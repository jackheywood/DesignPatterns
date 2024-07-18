using System.Text;

namespace Proxy.CompositeProxy.ArrayBacked;

public class MasonrySettingsStandard
{
    public bool Floors;
    public bool Pillars;
    public bool Walls;

    public bool? All
    {
        get
        {
            if (Pillars == Walls && Walls == Floors) return Pillars;
            return null;
        }
        set
        {
            if (!value.HasValue) return;
            Pillars = value.Value;
            Walls = value.Value;
            Floors = value.Value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Floors - {Floors}");
        sb.AppendLine($"Pillars - {Pillars}");
        sb.AppendLine($"Walls - {Walls}");
        sb.Append($"All - {All?.ToString() ?? "N/A"}");
        return sb.ToString();
    }
}