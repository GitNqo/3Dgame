using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject ofstaclePrefab;//障害物プレハブ
    Vector3 spawnPos = new Vector3(25,0,0);//スポーンする場所
    float elapsedTime ;//経過時間
 
    void Update()
    {
        //経過時間が2秒をこえたら
        elapsedTime += Time.deltaTime ;//毎Fの時間を足していく
        if (elapsedTime > 2.0f)
        {
            Instantiate(ofstaclePrefab, spawnPos, ofstaclePrefab.transform.rotation);
            elapsedTime =0.0f;//経過時間リセット
        }

    }
}
