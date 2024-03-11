using System;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorListener : MonoBehaviour
{

    private Dictionary<string, Action> handlerDict = new Dictionary<string, Action>();

    /// <summary>
    /// 
    /// ֡�¼�����
    /// 
    /// </summary>
    /// <param name="eventId"></param>
    public void On(string eventId, Action handler)
    {
        if (handlerDict.ContainsKey(eventId))
        {
            handlerDict[eventId] += handler;
        }
        else
        {
            handlerDict.Add(eventId, handler);
        }
    }

    /// <summary>
    /// ֡�¼��Ƴ�
    /// </summary>
    /// <param name="eventId"></param>
    /// <param name="handler"></param>
    public void Off(string eventId, Action handler)
    {
        if (handlerDict.ContainsKey(eventId))
        {
            handlerDict[eventId] -= handler;
        }
    }

    /// <summary>
    /// ������е�֡�¼�
    /// </summary>
    public void Clear()
    {
        handlerDict.Clear();
    }

    /// <summary>
    /// ����֡�¼�
    /// </summary>
    /// <param name="eventId"></param>
    public void OnAnimatorEvent(string eventId)
    {
        Action result = null;
        if (handlerDict.TryGetValue(eventId, out result))
        {
            result?.Invoke();
        }
    }
}

