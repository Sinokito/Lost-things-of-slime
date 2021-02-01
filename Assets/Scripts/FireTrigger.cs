using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// author:BkB
/// time:2021/1/30
/// 功能:意大利炮开炮
/// 说明：场景中要添加名称为FireSet的配套物体
/// </summary>
public class FireTrigger : MonoBehaviour
{

    //音效脚本
    AudioMgr AudioMgr;
    Rigidbody2D playerrigidbody2D;
    //发射史莱姆
    [Header("发射角度")]
    public int a, b;
    [Header("发射力度")]
    public float force1;
    //按钮动画
    Animator anim;


    private FireSet fireSet;//声明fireset
    private bool isFire = false;//是否已经开火
    private int number = 0;//在按钮上面物体的数量
    // Start is called before the first frame update
    void Start()
    {
        //有点耗费资源，但是懒得再添加一个tag了QWQ
        fireSet = GameObject.Find("FireSet").GetComponent<FireSet>();
        playerrigidbody2D = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        AudioMgr = AudioMgr.getinstance();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //按钮触发
    private void OnTriggerEnter2D(Collider2D other)
    {//判断进入物体的Tag是不是Player====这以后要改====

        //触发按钮动画,写在这<===========================
        

        if(other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Box"))
        {
            number++;//在按钮上面物体数量加一
            anim.SetBool("B4", true);
            if (!isFire)
            {
                FireCannon();
                isFire = true;
            }
           
        }
    }
    //按钮解除
    private void OnTriggerExit2D(Collider2D other)
    {//判断进入物体的Tag是不是Player====这以后要改====


        //触发按钮动画,写在这<===========================
        anim.SetBool("B4", false);

        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Box"))
        {
            number--;//在按钮上面物体数量减一
            //当且仅当按钮上面没有物体，并且已经开火的时候
            if(number == 0 && isFire == true)
            {
                //设置大炮没有开火
                isFire = false;
            }
        }
    }

    //开火
    private void FireCannon()
    {
        //Debug.Log("Fire!");
        //AudioMgr.audioPlay("bomb");
        //如果史莱姆在里面
        if (fireSet.getIsIn())
        {
            //Debug.Log("Slem is in!");
            //触发史莱姆发射动画
            //及其音效
            FireSlem();
            AudioMgr.audioPlay("bomb");
            //=========================================
        }

    }

    void FireSlem()
    {
        playerrigidbody2D.AddForce(new Vector2(a, b).normalized * force1);
    }



}
