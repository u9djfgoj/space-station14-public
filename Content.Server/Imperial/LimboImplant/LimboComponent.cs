using Robust.Shared.GameStates;

namespace Content.Server.Limbo;

/// <summary>
/// limbo thing
/// </summary>
[RegisterComponent]
[NetworkedComponent]
[Access(typeof(LimboSystem))]
public sealed partial class LimboComponent : Component
{
    public TimeSpan Difference = TimeSpan.FromSeconds(1);
    public TimeSpan Next = TimeSpan.FromSeconds(1);
}
