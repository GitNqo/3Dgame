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


    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

    }

    // Update is called once per frame
    void Update()
    {   //スペースキーがおされて、かつ、地面にいたら
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround )
        {
            rb.AddForce(Vector3.up * 20,ForceMode.Impulse);
            isOnGround = false ;//ジャンプした＝地面にいない
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

    }

}
