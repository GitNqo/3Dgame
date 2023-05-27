using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;//障害物プレハブ
    Vector3 spawnPos = new Vector3(25,0,0);//スポーンする場所
    float elapsedTime ;//経過時間
    PlayerContraller2 playerContrallerScriot;
    private void Start()
    {
        playerContrallerScriot = GameObject.Find("Player").GetComponent<PlayerContraller2>();
        //playerからスクリプトを奪ってくるイメージ
    }

    void Update()
    {
        //経過時間が2秒をこえて、かつゲームオーバーでない
        elapsedTime += Time.deltaTime ;//毎Fの時間を足していく
        if (elapsedTime > 2.0f && !playerContrallerScriot.gameOver)
        //!は否定なので、!playerContrallerScriot.gameOverの意味は「ゲームオーバーでなければ」になる
        //playerContrallerScriot.gameOver == falseと書いてもよい
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
            elapsedTime =0.0f;//経過時間リセット
        }

    }
}
