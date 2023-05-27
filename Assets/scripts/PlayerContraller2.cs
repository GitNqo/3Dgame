using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContraller2 : MonoBehaviour
{ 
     public float speed = 20; // 動く速さ

private Rigidbody rb; // Rididbody
    [SerializeField] float gravityModifier;//重力値調整用
    [SerializeField] float jumpForce;//ジャンプ力
    [SerializeField] bool isOnGround;//地面についているか
    public bool gameOver;
    Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {   //スペースキーがおされて、かつ、地面にいたら,ゲームオーバーでないなら
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce ,ForceMode.Impulse);
            isOnGround = false ;//ジャンプした＝地面にいない
            playerAnim.SetTrigger("Jump_trig");//ジャンプアニメ発動準備
        }



       
    }
    //衝突が起きたら実行
    private void OnCollisionEnter(Collision collision)
    {
        //ぶつかった相手（collision）のタグがGroundなら
        if(collision .gameObject.CompareTag("Ground"))
        {
            isOnGround = true;//地面についている状態に変更
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            playerAnim.SetBool("Death_b" , true);
            playerAnim.SetInteger("DeathType_int" , 2);
        }

    }

}
