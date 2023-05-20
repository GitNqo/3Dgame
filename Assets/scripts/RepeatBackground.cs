using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;//リピートの開始位置
    
    void Start()
    {
        startPos = transform .position ;//ゲーム開始位置の場所を記憶
    }


    void Update()
    {
        //なにか条件を満たしたら
        if (startPos.x - transform.position.x > 50.0f)
        {
            transform .position = startPos ;//場所をリセット
        }
    }
}
