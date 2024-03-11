
using GameFramework;
using GameFramework.Event;
/// <summary>
/// 服务器 未运行
/// </summary>
public sealed class DrunkerServerNoRunEventArgs : GameEventArgs
{
    public static readonly int EventId = typeof(DrunkerServerNoRunEventArgs).GetHashCode();


    public DrunkerServerNoRunEventArgs()
    {

    }

    public override int Id
    {
        get
        {
            return EventId;
        }
    }


    public static DrunkerServerNoRunEventArgs Create()
    {
        DrunkerServerNoRunEventArgs args = ReferencePool.Acquire<DrunkerServerNoRunEventArgs>();
        return args;
    }

    public override void Clear()
    {

    }
}

