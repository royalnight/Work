using UnityEngine;

public class NPC : MonoBehaviour
{
    #region NPC 方法
    private void Start()
    {
        PurchaseProp(0);
        TeskUpdate(0);
    }
    /// <summary>
    /// 對話
    /// </summary>
    /// <param name="Content"></param>
    private void Chat(string Content)
    {
        
    }
    /// <summary>
    /// 開啟商店
    /// </summary>
    /// <returns></returns>
    public bool OpenShop()
    {
        return true;
    }
    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="Itemprice"></param>
    public void PurchaseProp(int Itemprice = 100)
    {
        print("購買道具：" + Itemprice);   
    }
    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="TaskNumber"></param>
    public void GetTask(string TaskNumber)
    {
        print("任務編號：" + TaskNumber);
    }
    /// <summary>
    /// 任務更新
    /// </summary>
    /// <param name="Teskporp"></param>
    private void TeskUpdate(int Teskporp = 1)
    {
        print("獲得任務道具數量：" + Teskporp);
    }
   /// <summary>
   /// 完成任務
   /// </summary>
   /// <returns></returns>
    private bool FinishTesk()
    {
        return false;
    }
    #endregion
}
