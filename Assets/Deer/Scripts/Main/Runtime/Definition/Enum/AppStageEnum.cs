//================================================
//描 述 :  
//作 者 : 杜鑫 
//创建时间 : 2021-07-04 17-42-04  
//修改作者 : 杜鑫 
//修改时间 : 2021-07-04 17-42-04  
//版 本 : 0.1 
// ===============================================
public enum AppStageEnum
{
    /// <summary>
    /// 服务器相关信息极可能输出
    /// </summary>
    CheckServer = 0,
    /// <summary>
    /// 测试版本
    /// </summary>
    Debug = 1,
    /// <summary>
    /// 前期版本
    /// </summary>
    Alpha = 2,
    /// <summary>
    /// 中期版本
    /// </summary>
    Beta = 3,
    /// <summary>
    /// 后期版本 与发布版本没多大差别
    /// </summary>
    Rc = 4,
    /// <summary>
    /// 发布版本
    /// </summary>
    Release = 5
}
public enum ServerUseEnum
{
    LocalServer = 1,
    TestServer = 2,
    FormalServer = 3
}