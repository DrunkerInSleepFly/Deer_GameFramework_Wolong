
public class MessageBase
{
    public static int gzipLimit = 1024 * 30;

    byte[] bytes = null;
    bool byteZipped = false;
    public byte[] toEncodedByteArray()
    {
        if (bytes == null)
        {
            bytes = toByteArray();
            //byteZipped = bytes.Length > gzipLimit;
            //dataEncrypt(bytes);
            //if (byteZipped)
            //{
            //    // bytes = ServerUtility.gzip(bytes);
            //}
        }
        else
        {
            byteZipped = bytes.Length > gzipLimit;
            dataEncrypt(bytes);
            if (byteZipped)
            {
                // bytes = ServerUtility.gzip(bytes);
            }
        }
        return bytes;
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
    protected byte[] toByteArray()
    {
        //  return MyMessagePack.getInstance().write(this); 
        ByteBuffer buf = ByteBuffer.Allocate(1024 * 2);
        buf.WriteBytes(bytes);
        return buf.ToArray();
    }
    public byte[] getBytes()
    {
        return bytes;
    }
    public void setBytes(byte[] bytes)
    {
        this.bytes = bytes;
    }
    public bool isByteZipped()
    {
        return byteZipped;
    }
    //public int getAction() { 

    //}

}
