// ================================================
//描 述:
//作 者:
//创建时间:2023年7月4日
//修改作者:Drunker
//修改时间:2023年7月4日
//版 本:0.1 
// ===============================================
using System.Collections.Generic;

#if ODIN_INSPECTOR
#endif
using UnityEngine;
using UnityGameFramework.Runtime;
public partial class PrefabsPoolComponent : GameFrameworkComponent
{

    private Dictionary<string, PrefabsPool> m_poolDic = new Dictionary<string, PrefabsPool>();

    protected override void Awake()
    {
        base.Awake();
    }
    /// <summary>
    /// 创建对象池
    /// </summary>
    /// <param name="name"></param>
    /// <param name="prefabs"></param>
    /// <param name="parent"></param>
    /// <returns></returns>
    public PrefabsPool CreateMultiSpawnObjectPool(string name, GameObject prefabs, Transform parent, bool isInit = false, int initCount = 0)
    {
        if (m_poolDic.ContainsKey(name))
        {
            Debug.LogError($"m_poolDic have {name} key");
            return null;
        }
        PrefabsPool pool = PrefabsPool.Create(prefabs, parent, name, isInit, initCount);
        m_poolDic.Add(name, pool);
        return pool;
    }
    /// <summary>
    /// 获取对象池
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public PrefabsPool GetPool(string name)
    {
        if (m_poolDic.ContainsKey(name))
        {
            return m_poolDic[name];
        }
        return null;
    }
    /// <summary>
    /// 是否存在对象池
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public bool HasPool(string name)
    {
        return m_poolDic.ContainsKey(name);
    }
    /// <summary>
    /// 删除对象池
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public void DestroyObjectPool(string name)
    {
        if (m_poolDic.ContainsKey(name))
        {
            m_poolDic.Remove(name);
        }
    }
    /// <summary>
    /// 删除对象池
    /// </summary>
    /// <param name="pool"></param>
    /// <returns></returns>
    public void DestroyObjectPool(PrefabsPool pool)
    {
        if (m_poolDic.ContainsValue(pool))
        {
            m_poolDic.Remove(pool.Name);
        }
    }
}
