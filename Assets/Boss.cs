using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    int mp = 53;

    void Magic(int nowMp)
    {
        var useMp = 5;

        if(nowMp >= useMp)
        {
            nowMp -= useMp;
            Debug.Log("魔法攻撃をした。残りMPは"+nowMp+"。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        mp = nowMp;

    }

    // Start is called before the first frame update
    void Start()
    {   

        for(int i = 0; i< 11;i++)
        {
            Magic(mp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
