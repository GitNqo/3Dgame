using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContraller : MonoBehaviour
{ 
     public float speed = 20; // 動く速さ

private Rigidbody rb; // Rididbody


    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");
        var movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.AddForce(movement * speed);
    }
}
