using UnityEngine;

public class NPC : MonoBehaviour
{
    #region NPC ��k
    private void Start()
    {
        PurchaseProp(0);
        TeskUpdate(0);
    }
    /// <summary>
    /// ���
    /// </summary>
    /// <param name="Content"></param>
    private void Chat(string Content)
    {
        
    }
    /// <summary>
    /// �}�Ұө�
    /// </summary>
    /// <returns></returns>
    public bool OpenShop()
    {
        return true;
    }
    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="Itemprice"></param>
    public void PurchaseProp(int Itemprice = 100)
    {
        print("�ʶR�D��G" + Itemprice);   
    }
    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="TaskNumber"></param>
    public void GetTask(string TaskNumber)
    {
        print("���Ƚs���G" + TaskNumber);
    }
    /// <summary>
    /// ���ȧ�s
    /// </summary>
    /// <param name="Teskporp"></param>
    private void TeskUpdate(int Teskporp = 1)
    {
        print("��o���ȹD��ƶq�G" + Teskporp);
    }
   /// <summary>
   /// ��������
   /// </summary>
   /// <returns></returns>
    private bool FinishTesk()
    {
        return false;
    }
    #endregion
}
