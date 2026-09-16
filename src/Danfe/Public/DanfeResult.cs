using System.Collections.Generic;

namespace Direction.NFSe.Danfe;

public sealed class DanfeResult
{
    public DanfeEnvironment Environment { get; init; }
    public string Html { get; init; } = string.Empty;
    public IReadOnlyList<DanfeWarning> Warnings { get; init; } = System.Array.Empty<DanfeWarning>();
}
