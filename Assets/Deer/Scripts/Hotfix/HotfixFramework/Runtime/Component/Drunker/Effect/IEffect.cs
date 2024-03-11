// ================================================
//�� ��:
//�� ��:
//����ʱ��:2023��5��31��
//�޸�����:Wyp
//�޸�ʱ��:2023��5��31��
//�� ��:0.1 
// ===============================================

public interface IEffect
{
    /// <summary>
    /// ��Ч����
    /// </summary>
    /// <returns></returns>
    public string EffectName();
    /// <summary>
    /// ��Ч����
    /// </summary>
    /// <returns></returns>
    public EffectEnum EffectEnum();
    /// <summary>
    /// ������Ч��Ϣ
    /// </summary>
    /// <param name="effectName"></param>
    /// <param name="effectEnum"></param>
    public void SetEffectInfo(string effectName, EffectEnum effectEnum);
    /// <summary>
    /// ע���¼����
    /// </summary>
    public void OnShow();
    /// <summary>
    /// ��Ч����
    /// </summary>
    public void OnEffectFinish();
    /// <summary>
    /// ȡ��ע���¼����
    /// </summary>
    public void OnRecovery();
}

public enum EffectEnum
{
    None = -1,
    /// <summary>
    /// ������Ч
    /// </summary>
    Animation,
    Particle
}
