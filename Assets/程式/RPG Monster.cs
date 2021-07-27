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
    [Header("�����D��"), Tooltip("�O�_����")]
    public string drop = "�C������";
    public bool onfloor = false;
    [Header("�����D����v"), Range(0, 1)]
    public float Probability_of_drop_items = 1;



    private AudioClip AudioClip;
    [Header("�����D�㭵��")]
    public bool propsound;
    private AudioSource AudioSource;
    private Rigidbody2D Rigidbody2D;
    private Animator animator;
    #endregion


}
