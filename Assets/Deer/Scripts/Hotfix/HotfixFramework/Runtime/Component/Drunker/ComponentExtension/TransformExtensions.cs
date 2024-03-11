using UnityEngine;

public static class TransformExtensions
{
    public static Transform FindInChild(this Transform trans, string name)
    {
        if (trans.childCount <= 0)
        {
            return null;
        }

        for (int i = 0; i < trans.childCount; i++)
        {
            Transform child = trans.GetChild(i);
            if (name == child.name)
            {
                return child;
            }
            Transform citem = child.FindInChild(name);
            if (citem != null)
                return citem;
        }

        return null;
    }

    public static void SetActive(this Transform trans, bool value)
    {
        trans.gameObject.SetActive(value);
    }
}

