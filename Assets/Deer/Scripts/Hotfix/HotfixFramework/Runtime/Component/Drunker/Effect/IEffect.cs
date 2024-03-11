// ================================================
//描 述:
//作 者:
//创建时间:2023年5月31日
//修改作者:Wyp
//修改时间:2023年5月31日
//版 本:0.1 
// ===============================================

public interface IEffect
{
    /// <summary>
    /// 特效名字
    /// </summary>
    /// <returns></returns>
    public string EffectName();
    /// <summary>
    /// 特效类型
    /// </summary>
    /// <returns></returns>
    public EffectEnum EffectEnum();
    /// <summary>
    /// 设置特效信息
    /// </summary>
    /// <param name="effectName"></param>
    /// <param name="effectEnum"></param>
    public void SetEffectInfo(string effectName, EffectEnum effectEnum);
    /// <summary>
    /// 注册事件入口
    /// </summary>
    public void OnShow();
    /// <summary>
    /// 特效结束
    /// </summary>
    public void OnEffectFinish();
    /// <summary>
    /// 取消注册事件入口
    /// </summary>
    public void OnRecovery();
}

public enum EffectEnum
{
    None = -1,
    /// <summary>
    /// 动画特效
    /// </summary>
    Animation,
    Particle
}
