using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// @author:BkB
/// @time:2021/1/31
/// @作用:史莱姆音效
/// 
/// </summary>
public class SlemAudio : MonoBehaviour
{
    AudioMgr audioMgr;
    Animator anim;

    static int moveState = Animator.StringToHash("move");//获取move状态的哈希id
    static int dieState = Animator.StringToHash("die");//获取move状态的哈希id
    AnimatorStateInfo info;//表示当前动画状态ID
    bool hasplayed = false;
    bool hasplayeddie = false;
    // Start is called before the first frame update
    void Start()
    {
        audioMgr = AudioMgr.getinstance();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        info = anim.GetCurrentAnimatorStateInfo(0);//更新当前动画状态ID
        //史莱姆移动音效
        if (info.shortNameHash == moveState)//判断两者哈希值
        {
            if (!hasplayed)
            {
                audioMgr.audioPlay("slemwalk", true);
                hasplayed = true;
            }
        }
        else
        {
            if (hasplayed)
            {
                audioMgr.audioStop("slemwalk");
                hasplayed = false;
            }

        }
        //史莱姆死亡音效
        if (info.shortNameHash == dieState)//判断两者哈希值
        {
            if (!hasplayeddie)
            {
                audioMgr.audioPlay("slemdied");
                hasplayeddie = true;
            }
        }
        else
        {
            if (hasplayeddie)
            {
                audioMgr.audioStop("slemdied");
                hasplayeddie = false;
            }

        }


    }





}
