using UnityEngine;

public class RPGMonster : MonoBehaviour
{
    #region
    [Header("Move speed"), Range(0, 10)]
    public float speed = 3.5f;
    [Header("attack damage"), Range(0, 500)]
    public float damage = 100;
    [Header("health"), Range(0, 5000)]
    public float heal = 350;
    [Header("掉落道具"), Tooltip("是否掉落")]
    public string drop = "遊戲物件";
    public bool onfloor = false;
    [Header("掉落道具機率"), Range(0, 1)]
    public float Probability_of_drop_items = 1;



    private AudioClip AudioClip;
    [Header("掉落道具音效")]
    public bool propsound;
    private AudioSource AudioSource;
    private Rigidbody2D Rigidbody2D;
    private Animator animator;
    #endregion


}
