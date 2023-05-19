using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField ]private GameObject player;//publickじゃなくてもインスペクターからいじれる

    private Rigidbody rb; 

    void Start()
    {
       rb = GetComponent <Rigidbody >();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce (player.transform.position  - transform.position ) ;
    }
}
