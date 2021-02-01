using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// author:BkB
/// time:2021/1/30
/// target:放在意大利炮底部，用来固定史莱姆，并确保史莱姆是否在内。
/// 与FireTrigger配套使用
/// </summary>
public class FireSet : MonoBehaviour
{

    public Transform targetTransform;//炮膛底部的恰当位置

    private bool isIn = false;//判断史莱姆是否在内的变量
    

    //得到史莱姆是否在内
    public bool getIsIn()
    {
        return isIn;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// 史莱姆进入炮膛指定位置后，锁住史莱姆，准备发射
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
           // Debug.Log("Get in!");
            GameObject obj = collision.gameObject;
            obj.transform.position = targetTransform.position;//移动玩家到目标位置

            //播放音效==============================================
            //表示就位
            
            isIn = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           // Debug.Log("Get out!");
            isIn = false;
        }
    }



}
