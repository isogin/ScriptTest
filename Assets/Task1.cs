using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[5];  //好きな値で初期化
        int x, i;

        //配列の各要素を順番に表示
        for (i = 0; i < 5; i++)
        {
            x = Random.Range(1, 10);
            array[i] = x;
            Debug.Log(array[i]);
        }


        //配列の各要素を逆順に表示
        for(i = 0; i < 5; i++)
        {
            Debug.Log(array[4 - i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
