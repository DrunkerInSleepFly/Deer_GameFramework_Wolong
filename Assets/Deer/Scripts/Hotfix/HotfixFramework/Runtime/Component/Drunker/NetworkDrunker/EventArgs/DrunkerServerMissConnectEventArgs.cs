
using GameFramework;
using GameFramework.Event;
/// <summary>
/// 服务器 未运行
/// </summary>
public sealed class DrunkerServerMissConnectEventArgs : GameEventArgs
{
    public static readonly int EventId = typeof(DrunkerServerMissConnectEventArgs).GetHashCode();


    public DrunkerServerMissConnectEventArgs()
    {

    }

    public override int Id
    {
        get
        {
            return EventId;
        }
    }


    public static DrunkerServerMissConnectEventArgs Create()
    {
        DrunkerServerMissConnectEventArgs args = ReferencePool.Acquire<DrunkerServerMissConnectEventArgs>();
        return args;
    }

    public override void Clear()
    {

    }
}
