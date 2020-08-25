using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int mp = 53;

    // 魔法攻撃用の関数
    public void Magic()
    {
        if(mp >= 5)
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

    public class HattenKadai : MonoBehaviour
{
        // Start is called before the first frame update
        void Start()
        {
            Boss boss = new Boss();

            //Magic関数を10回使う
            for(int i = 0; i < 11; i++)
            {
                //魔法用の関数を呼び出す  
                boss.Magic();
            }
            
        }

        // Update is called once per frame
        void Update()
    {
        
    }
}
