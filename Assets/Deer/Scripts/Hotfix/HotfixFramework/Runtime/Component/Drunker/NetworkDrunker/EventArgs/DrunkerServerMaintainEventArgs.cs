
using GameFramework;
using GameFramework.Event;
/// <summary>
/// 服务器维护时
/// </summary>
public sealed class DrunkerServerMaintainEventArgs : GameEventArgs
{
    public static readonly int EventId = typeof(DrunkerServerMaintainEventArgs).GetHashCode();
    string t = "";

    public DrunkerServerMaintainEventArgs()
    {

    }

    public override int Id
    {
        get
        {
            return EventId;
        }
    }

    public string T { get => t; set => t = value; }

    public static DrunkerServerMaintainEventArgs Create(string t)
    {
        DrunkerServerMaintainEventArgs maintainEventArgs = ReferencePool.Acquire<DrunkerServerMaintainEventArgs>();
        maintainEventArgs.t = t;
        return maintainEventArgs;
    }



    public override void Clear()
    {
        t = "";
    }
}
