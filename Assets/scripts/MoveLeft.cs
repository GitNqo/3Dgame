using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField ] float speed = 30;//Groundが動く速さ
    PlayerContraller2 playerContrallerScriot;
    float leftBound = -15;//左の限界値

    void Start()
    {
        playerContrallerScriot = GameObject.Find("Player").GetComponent<PlayerContraller2>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerContrallerScriot.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
