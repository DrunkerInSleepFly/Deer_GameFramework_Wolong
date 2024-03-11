
using GameFramework;
using GameFramework.Event;
/// <summary>
/// mServerSocket.Connected=false 事件。 丢失连接 需要出一个转圈，在此圈过程中网络模块尝试重新建立连接中
/// </summary>
public sealed class DrunkerNetworkConnectEventArgs : GameEventArgs
{
    public static readonly int EventId = typeof(DrunkerNetworkConnectEventArgs).GetHashCode();
    bool mConnected = true;

    public DrunkerNetworkConnectEventArgs()
    {

    }

    public override int Id
    {
        get
        {
            return EventId;
        }
    }

    public bool MConnected { get => mConnected; set => mConnected = value; }


    /// <summary>
    /// 创建网络连接关闭事件。
    /// </summary>
    /// <param name="e">内部事件。</param>
    /// <returns>创建的网络连接关闭事件。</returns>
    public static DrunkerNetworkConnectEventArgs Create(bool MConnected)
    {
        DrunkerNetworkConnectEventArgs drunkerNetworkClosedEventArgs = ReferencePool.Acquire<DrunkerNetworkConnectEventArgs>();
        drunkerNetworkClosedEventArgs.MConnected = MConnected;
        return drunkerNetworkClosedEventArgs;
    }

    public override void Clear()
    {
        MConnected = true;
    }
}
