
public interface IServerMessageManager
{
    void MessageReceive(int action, byte[] data);

    void UpdateMessage();
}

