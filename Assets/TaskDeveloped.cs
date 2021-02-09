using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int hp;
    int power;
    int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");

        this.hp -= damage;
    }

    public void Magic()
    {
        if (mp > 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}


public class TaskDeveloped : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss laseboss = new Boss();

        laseboss.Attack();

        laseboss.Defence(3);

        laseboss.Magic();

        for(int i = 0; i < 10; i++)
        {
            laseboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
