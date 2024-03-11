using System.Collections.Generic;
using UnityEngine;
public class PrefabsPool
{
    public static PrefabsPool Create(GameObject prefabs, Transform parent, string name, bool isInit = false, int initCount = 64)
    {
        PrefabsPool pool = new PrefabsPool(prefabs, parent, name, isInit, initCount);
        return pool;
    }

    private string m_name;
    public string Name
    {
        get => m_name;
    }
    private GameObject m_prefabsGameObject;
    private Transform m_parent;

    private List<GameObject> m_poolItemList = new List<GameObject>();
    private List<GameObject> m_itemList = new List<GameObject>();

    public PrefabsPool(GameObject prefabs, Transform parent, string name, bool isInit = false, int initCount = 64)
    {
        m_prefabsGameObject = prefabs;
        m_parent = parent;
        m_name = name;
        if (isInit)
        {
            Init(initCount);
        }
    }
    void Init(int initCount)
    {
        for (int i = 0; i < initCount; i++)
        {
            GameObject go1 = GameObject.Instantiate(m_prefabsGameObject, m_parent);
            go1.SetActive(false);
            m_poolItemList.Add(go1);
        }
    }
    /// <summary>
    /// 获取对象
    /// </summary>
    /// <returns></returns>
    public GameObject Spawn(bool isActive = true, Transform parent = null)
    {
        if (m_poolItemList.Count > 0)
        {

            GameObject go = null;
            do
            {
                go = m_poolItemList[0];
                m_poolItemList.RemoveAt(0);
            } while (go == null && m_poolItemList.Count > 0);

            if (go == null)
            {
                GameObject go2 = GameObject.Instantiate(m_prefabsGameObject, parent == null ? m_parent : parent);
                if (isActive)
                {
                    go2.SetActive(true);
                }
                m_itemList.Add(go2);
                return go2;
            }


            if (isActive)
            {
                go.SetActive(true);
            }
            go.transform.SetParent(parent == null ? m_parent : parent);
            m_itemList.Add(go);
            return go;
        }

        GameObject go1 = GameObject.Instantiate(m_prefabsGameObject, parent == null ? m_parent : parent);
        if (isActive)
        {
            go1.SetActive(true);
        }
        m_itemList.Add(go1);
        return go1;
    }
    /// <summary>
    /// 回收对象
    /// </summary>
    /// <param name="target"></param>
    public void Unspawn(GameObject target)
    {
        if (!m_itemList.Contains(target))
        {
            Debug.LogError("ItemList Is not Contains target");
            return;
        }
        target.SetActive(false);
        target.transform.SetParent(m_parent);
        m_poolItemList.Add(target);
        m_itemList.Remove(target);
    }
    /// <summary>
    /// 回收全部对象
    /// </summary>
    public void UnspawnAll()
    {
        for (int i = 0; i < m_itemList.Count; i++)
        {
            m_itemList[i].transform.parent = m_parent;
            m_itemList[i].SetActive(false);
            m_poolItemList.Add(m_itemList[i]);
        }
        m_itemList.Clear();
    }


}