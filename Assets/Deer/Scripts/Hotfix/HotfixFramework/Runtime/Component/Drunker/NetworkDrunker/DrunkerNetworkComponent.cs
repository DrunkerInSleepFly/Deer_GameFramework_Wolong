using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;
using UnityGameFramework.Runtime;

public class DrunkerNetworkComponent : GameFrameworkComponent
{

    public string ServerIP = "8.140.192.137:9722";
    public bool OpenHeart = false;
    public int HeartCheckTimes = 10;
    // int HeartIntervalTimes = 10;

    public Socket mServerSocket
    {
        get;
        private set;
    }
    /*
     连接成功后服务器会下发anction 0 success
     */
    public bool MConnected { get => mConnected; set => mConnected = value; }

    public void ChangeConnected(bool mConnected)
    {
        this.mConnected = mConnected;
        Debug.Log("DrunkerNetworkConnectEventArgs.Create(true)");
        DrunkerNetworkConnectEventArgs drunkerNetworkClosedEventArgs = DrunkerNetworkConnectEventArgs.Create(true);
        GameEntryMain.Event.Fire(this, drunkerNetworkClosedEventArgs);
    }

    public NetworkReachability m_internetReachability;

    public bool MHeart { get => mHeart; set => mHeart = value; }

    private Socket mClientSocket;
    private IPEndPoint mIPEndPoint;
    private string mServerIPAddress;
    private int mServerPort;
    private string mRecvStr;
    private string mSendStr;
    private bool mConnected = false;
    private bool mHeart = false;

    private byte[] mRecvData = new byte[1024 * 5];
    private byte[] mSendData = new byte[1024 * 2];
    private int mRecvLength = 0;
    private Thread mRecvThread;
    bool isGoConnect = false;

    IServerMessageManager m_serverMessageMgr;

    public void InitUrl(string v, IServerMessageManager serverMessageMgr)
    {
        if (v == "")
        {
            v = ServerIP;
        }
        m_serverMessageMgr = serverMessageMgr;
        string[] s = v.Split(":");
        mServerIPAddress = s[0];
        mServerPort = int.Parse(s[1]);
        isGoConnect = true;
        go();
    }

    private void go()
    {
        if (isGoConnect)
        {
            InitSocket();
        }
        // mServerIPAddress = ip;
        // mServerPort = port;

    }
    public void close()
    {
        mServerSocket.Close();
    }

    private void InitSocket()
    {
        mRecvLength = 0;
        isGoTestConnect = false;
        MConnected = false;
        mIPEndPoint = new IPEndPoint(IPAddress.Parse(mServerIPAddress), mServerPort);
        mRecvThread = new Thread(new ThreadStart(SocketReceive));

        mRecvThread.Start();
        // SocketConnect();
    }
    public bool SocketConnect()
    {
        if (mServerSocket != null)
        {
            mServerSocket.Close();
        }
        mServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        try
        {
            mServerSocket.Connect(mIPEndPoint);
            if (MConnected)
            {
                isGoTestConnect = false;
                isStart = false;
                Debug.Log("连接成功");
                return true;
            }
            m_recennetInterval = 2;
            isGoTestConnect = true;
            Debug.Log("开启测试连接");
            return false;
        }
        catch (Exception e)
        {
            Debug.Log("无法连接服务器" + e.ToString());
            m_recennetInterval = 1;
            return false;
        }

    }
    public void SocketReceive()
    {
        StartConnext();
        while (true)
        {
            if (m_isReConnext)
            {
                if (MConnected)
                {
                    isGoTestConnect = false;
                    isStart = false;
                    m_isReConnext = false;
                    Debug.Log("连接成功");
                }
                else
                {
                    if (m_recennetInterval <= 0)
                    {
                        Reconnext();
                        continue;
                    }
                    if (!isGoTestConnect)
                        continue;
                }
            }
            if (mServerSocket == null)
            {
                continue;
            }
            if (!mServerSocket.Connected)
            {
                continue;
            }
            mRecvData = new byte[1024 * 5];
            try
            {
                mRecvLength = mServerSocket.Receive(mRecvData);
            }
            catch (Exception e)
            {
                //  StartTestConnect();
                // GameEntryMain.Event.Fire(this, DrunkerServerMissConnectEventArgs.Create());
                //希望能弹个提示就好
                //  Debug.Log("SocketReceive" + e.ToString());
                //Debug.Log("希望能弹个提示就好");
                StartReconnext();
                continue;
            }
            if (mRecvLength == 0)
            {
                if (MConnected)
                {
                    StartReconnext();
                }
                continue;
            }
            if (mServerSocket.Connected)
            {
                byte[] data = new byte[mRecvLength];
                ByteBuffer buf = ByteBuffer.Allocate(mRecvData);
                buf.ReadBytes(data, 0, mRecvLength);
                SocketReceive(data, mRecvLength);
            }
            else
            {
                continue;
            }
            // buf.WriteInt((byte)(((MessageBase)message).isByteZipped() ? 1 : 0));

            //  mRecvStr = Encoding.ASCII.GetString(mRecvData, 0, mRecvLength);
            //  Debug.Log("SocketReceive :"+ mRecvStr);
            //  Controller.instance.s = mRecvStr;
        }
    }

    public void SocketSend(byte[] bytes)
    {
        if (mServerSocket == null)
        {
            StartReconnext();
            return;
        }
        if (!mServerSocket.Connected)
        {
            StartReconnext();
            return;
        }
        mServerSocket.Send(bytes, bytes.Length, SocketFlags.None);
    }

    private void StartConnext()
    {
        m_reconnextNumber = 20;
        m_isReConnext = false;
        MConnected = false;
        isGoTestConnect = false;
        if (m_internetReachability == NetworkReachability.NotReachable)
        {
            StartReconnext();
            return;
        }
        if (!SocketConnect())
        {
            m_isReConnext = true;
            Debug.Log("m_isReConnext = true");
        }
    }
    private bool isGoTestConnect;
    private float m_recennetInterval;
    private bool m_isReConnext;
    private float m_reconnextNumber;

    private void StartReconnext()
    {
        Debug.Log("StartReconnext");
        if (m_isReConnext)
            return;
        m_reconnextNumber = 20;
        m_recennetInterval = 0;
        m_isReConnext = true;
        Debug.Log("m_isReConnext");
        MConnected = false;
        isGoTestConnect = false;

        Debug.Log("MConnected_" + MConnected);

        Reconnext();
    }
    private void Reconnext()
    {
        if (m_recennetInterval > 0)
        {
            return;
        }
        mServerSocket = null;
        if (m_internetReachability == NetworkReachability.NotReachable)
        {
            m_recennetInterval = 0.1f;
            return;
        }
        DrunkerServerMissConnectEventArgs reconnnextEventArgs = DrunkerServerMissConnectEventArgs.Create();
        GameEntryMain.Event.Fire(this, reconnnextEventArgs);
        MConnected = false;
        Debug.Log("MConnected_" + MConnected);
        if (!SocketConnect())
        {
            m_reconnextNumber--;
            DrunkerNetworkConnectEventArgs drunkerNetworkClosedEventArgs = DrunkerNetworkConnectEventArgs.Create(false);
            GameEntryMain.Event.Fire(this, drunkerNetworkClosedEventArgs);
            if (m_reconnextNumber <= 0)
            {
                m_isReConnext = false;
                DrunkerServerNoRunEventArgs serverMissEventArgs = DrunkerServerNoRunEventArgs.Create();
                GameEntryMain.Event.Fire(this, serverMissEventArgs);
                return;
            }
            return;
        }
        m_isReConnext = false;
    }

    public void SocketSend(MessageBase request)
    {
        ByteBuffer byteBuffer = MessagePackEncoder.Instance.encode(request);
        byte[] bytes = byteBuffer.ToArray();
        SocketSend(bytes);
    }
    public void dataEncrypt(byte[] bytes)
    {
        byte xor = (byte)(bytes.Length % 256);
        if (xor == 0)
        {
            xor = 1;
        }
        for (int i = 0; i < bytes.Length; i++)
        {
            bytes[i] = (byte)(bytes[i] ^ (xor));
        }
    }
    public static int MAX_IMAGE_SIZE = 5 * 1024 * 1024;
    public static int DATA_LEN_HEADER = 0;


    private bool isStart = false;
    private int dataLength = 0;
    int isZip = 0;
    int action = 0;
    byte[] cbytes;
    private int readedBytes;

    //dncode代码包含在此方法了
    void SocketReceive(byte[] bytes, int mRecvLength)
    {
        byte[] suplusBytes;
        int suplusLenght = 0;
        ByteBuffer buf = ByteBuffer.Allocate(bytes);
        // Debug.Log("SocketReceive:" + mRecvLength);
        {
            if (mRecvLength > DATA_LEN_HEADER && mRecvLength < MAX_IMAGE_SIZE)
            {
                // Debug.Log("Drunker SocketReceive action :mRecvLength:" + mRecvLength);
                if (!isStart)
                {
                    isStart = true;

                    // buf.WriteInt((byte)(((MessageBase)message).isByteZipped() ? 1 : 0));              
                    dataLength = buf.ReadInt();//-1  - 4
                                               // int start =1+4;
                    isZip = buf.ReadByte();
                    action = buf.ReadInt();

                    cbytes = new byte[dataLength];

                    int bodyBytes = mRecvLength - 9;

                    Debug.Log("Drunker SocketReceive action :" + action + "isZip:" + isZip + " readedBytes:" + readedBytes + "dataLength:" + dataLength);
                    //if (readedBytes==0|| dataLength==0)
                    //{
                    //    StartTestConnect();
                    //    isStart = false;
                    //    //GameEntryMain.Event.Fire(this, DrunkerServerMissConnectEventArgs.Create());
                    //    return;
                    //}

                    readedBytes = dataLength >= bodyBytes ? bodyBytes : dataLength;

                    buf.ReadBytes(cbytes, 0, readedBytes);

                    //  Debug.Log("Drunker SocketReceive action :" + action + "isZip:" + isZip + " readedBytes:" + readedBytes);
                    if (readedBytes < dataLength)
                    {
                        return;
                    }
                    suplusLenght = bodyBytes - readedBytes;
                }
                else
                {
                    //if (cbytes.Length < readedBytes+ mRecvLength)
                    //{
                    //    isStart = false;
                    //    StartTestConnect();
                    //    return;
                    //}
                    int bodyBytes = readedBytes + mRecvLength <= dataLength ? mRecvLength : dataLength - readedBytes;

                    for (int i = 0; i < bodyBytes; i++)
                    {
                        cbytes[readedBytes + i] = buf.ReadByte();
                    }

                    readedBytes += bodyBytes;

                    //Debug.Log("Drunker SocketReceive action :" + action + "isZip:" + isZip + " readedBytes:" + readedBytes);
                    if (readedBytes < dataLength)
                    {
                        return;
                    }

                    suplusLenght = mRecvLength - bodyBytes;
                }
                isStart = false;
                if (DeerSettingsUtils.DeerGlobalSettings.AppStage == AppStageEnum.CheckServer)
                {
                    //  Logger.Debug(string.Format("Drunker SocketReceive action :" + action + "isZip:" + isZip + " dataLength:" + dataLength));
                    Debug.Log("Drunker SocketReceive action :" + action + "isZip:" + isZip + " cbytes.Length:" + cbytes.Length);
                }

                if (isZip == 1)
                {
                    MemoryStream ms = new MemoryStream(cbytes);
                    GZipStream zip = new GZipStream(ms, CompressionMode.Decompress, true);
                    MemoryStream msreader = new MemoryStream();
                    byte[] buffer = new byte[0x1000];
                    while (true)
                    {
                        int reader = zip.Read(buffer, 0, buffer.Length);
                        if (reader <= 0)
                        {
                            break;
                        }
                        msreader.Write(buffer, 0, reader);
                    }
                    zip.Close();
                    ms.Close();
                    msreader.Position = 0;
                    buffer = msreader.ToArray();
                    msreader.Close();
                    dataEncrypt(buffer);

                    m_serverMessageMgr?.MessageReceive(action, buffer);
                }
                else
                {
                    dataEncrypt(cbytes);

                    m_serverMessageMgr?.MessageReceive(action, cbytes);
                }
            }

            if (suplusLenght > 0)
            {
                suplusBytes = new byte[suplusLenght];
                buf.ReadBytes(suplusBytes, 0, suplusLenght);

                SocketReceive(suplusBytes, suplusLenght);
            }
            //ByteBuffer buf = ByteBuffer.Allocate(bytes);
            //// buf.WriteInt((byte)(((MessageBase)message).isByteZipped() ? 1 : 0));              
            //int dataLength = buf.ReadInt();//-1  - 4
            //                               // int start =1+4;
            //int isZip=   buf.ReadByte();                   
            //int action = buf.ReadInt();
            //if (GameSettingsUtils.GameGlobalSettings.FrameworkGlobalSettings.AppStage == AppStageEnum.CheckServer)
            //{
            //    Logger.Debug(string.Format("Drunker SocketReceive action :" + action + "isZip:" + isZip + " dataLength:" + dataLength));
            //    Debug.Log("Drunker SocketReceive action :" + action + "isZip:" + isZip + " dataLength:" + dataLength);
            //}
            //byte[] data = new byte[dataLength];

            //buf.ReadBytes(data, 0, dataLength);
            //if (isZip == 1)
            //{
            //    MemoryStream ms = new MemoryStream(data);
            //    GZipStream zip = new GZipStream(ms, CompressionMode.Decompress, true);
            //    MemoryStream msreader = new MemoryStream();
            //    byte[] buffer = new byte[0x1000];
            //    while (true)
            //    {
            //        int reader = zip.Read(buffer, 0, buffer.Length);
            //        if (reader <= 0)
            //        {
            //            break;
            //        }
            //        msreader.Write(buffer, 0, reader);
            //    }
            //    zip.Close();
            //    ms.Close();
            //    msreader.Position = 0;
            //    buffer = msreader.ToArray();
            //    msreader.Close();
            //    dataEncrypt(buffer);

            //    m_serverMessageMgr?.MessageReceive(action, buffer);
            //}
            //else {
            //    dataEncrypt(data);

            //    m_serverMessageMgr?.MessageReceive(action, data);
            //}    
        }


    }

    //public ResponseMessage Deserialize<T>(byte[] data) where T : ResponseMessage
    //{
    //    ResponseMessage message = MessagePackSerializer.Deserialize<T>(data);
    //    switch (message)
    //    {
    //        //case RPCLoginClient.Response x:
    //        //    Debug.Log(x.token);
    //        //    Debug.Log(x.sid);
    //        //    break;            
    //        default:
    //            break;
    //    }
    //    return message;
    //}



    private void Update()
    {
        if (mConnected)
        {
            m_serverMessageMgr?.UpdateMessage();
        }

        m_internetReachability = Application.internetReachability;

        if (m_isReConnext)
        {
            if (m_recennetInterval > 0)
            {
                m_recennetInterval -= Time.deltaTime;
            }
        }

    }
    //int count=20;
    //int testTimes = 0;
    //public void StartTestConnect()
    //{
    //    Debug.Log("StartTestConnect---");
    //    isStart = false;
    //    isGoTestConnect = true;
    //    TestConnect();           
    //}

    //private void LastTestConnect()
    //{
    //    InitSocket();
    //}
    //private void TestConnect()
    //{           
    //    Debug.Log("MConnected:" + MConnected);
    //    //  if (MConnected)
    //    if (mServerSocket.Connected)           
    //    {
    //        testTimes = 0;               
    //       // GameEntryMain.Timer.CancelTimer(TestConnectTimerId);
    //    }
    //    else
    //    {
    //        testTimes++;            
    //        if (testTimes == count)
    //        {
    //            testTimes = 0;
    //           // isTestConnect = false;
    //           // GameEntryMain.Timer.PauseTimer(TestConnectTimerId);
    //            //提示网络断开连接
    //            GameEntryMain.Event.Fire(this, DrunkerServerNoRunEventArgs.Create());
    //        }
    //        else
    //        {
    //            //服务器无法连接，重新初始化socket 并启动一个新线程顶替前一个线程的工作
    //            InitSocket();
    //            GameEntryMain.Event.Fire(this, DrunkerServerMissConnectEventArgs.Create());
    //          //  TestConnectTimerId = GameEntryMain.Timer.AddOnceTimer(2000, TestConnect);
    //        }
    //    }
    //}
}
