using System;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorListener : MonoBehaviour
{

    private Dictionary<string, Action> handlerDict = new Dictionary<string, Action>();

    /// <summary>
    /// 
    /// 帧事件监听
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
    /// 帧事件移除
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
    /// 清除所有的帧事件
    /// </summary>
    public void Clear()
    {
        handlerDict.Clear();
    }

    /// <summary>
    /// 触发帧事件
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

