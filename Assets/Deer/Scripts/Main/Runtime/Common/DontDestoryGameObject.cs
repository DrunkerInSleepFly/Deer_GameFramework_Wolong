// ================================================
//描 述:
//作 者:杜鑫
//创建时间:2022-06-07 11-23-22
//修改作者:杜鑫
//修改时间:2022-06-07 11-23-22
//版 本:0.1 
// ===============================================
using UnityEngine;

/// <summary>
/// Please modify the description.
/// </summary>
public class DontDestoryGameObject : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}