using UnityEngine;
public class MessagePackEncoder : Singleton<MessagePackEncoder>
{
    public static int gzipLimit = 1024 * 30;


    private static byte[] toByteArray(int iSource)
    {
        byte[] bLocalArr = new byte[4];
        for (int i = 0; (i < 4); i++)
        {
            bLocalArr[4 - i - 1] = (byte)(iSource >> 8 * i & 0xFF);
        }
        return bLocalArr;
    }

    public ByteBuffer encode(MessageBase message)
    {
        if (DeerSettingsUtils.DeerGlobalSettings.AppStage == AppStageEnum.CheckServer)
        {
            if (message.getBytes() != null)
            {
                Debug.Log("reuse message byte :" + message.GetType().FullName);
            }
        }

        byte[] bytes = message.toEncodedByteArray();
        int len = bytes.Length;
        ByteBuffer buf = ByteBuffer.Allocate(len + 4);
        buf.WriteBytes(toByteArray(len));
        // buf.WriteInt((byte)(((MessageBase)message).isByteZipped() ? 1 : 0));
        buf.WriteBytes(bytes);
        //logSpecialMsg(session, message, len);
        //LoggerService.logOutput(session, (MessageBase)message);
        //Debug.Log(len);
        return buf;

    }
}
