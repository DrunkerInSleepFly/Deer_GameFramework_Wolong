
using GameFramework;
using GameFramework.Event;
/// <summary>
/// 主服务器 未运行
/// </summary>
public sealed class DrunkerServerMainServerMissConnectEventArgs : GameEventArgs
{
    public static readonly int EventId = typeof(DrunkerServerMainServerMissConnectEventArgs).GetHashCode();


    public DrunkerServerMainServerMissConnectEventArgs()
    {

    }

    public override int Id
    {
        get
        {
            return EventId;
        }
    }


    public static DrunkerServerMainServerMissConnectEventArgs Create()
    {
        DrunkerServerMainServerMissConnectEventArgs args = ReferencePool.Acquire<DrunkerServerMainServerMissConnectEventArgs>();
        return args;
    }

    public override void Clear()
    {

    }
}