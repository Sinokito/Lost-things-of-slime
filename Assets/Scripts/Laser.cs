using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    //激光发射起点
    private GameObject LaserStart;
    //门抬起动画
    public  Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        LaserStart = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //射线碰撞如果碰撞物体的标签是玩家则开门
        RaycastHit2D hit = Physics2D.Raycast(LaserStart.transform.position,Vector3.down, float.MaxValue);
        if (hit.collider.tag!= "Ground") anim.SetBool("isCover", true);
        else anim.SetBool("isCover", false);
    }
}
