using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D Player;//获取刚体
    public float Speed;//走路速度
    public float JumpHigh;//跳跃高度
    public LayerMask Ground;//地面图层
    public Transform GroundCheck;//脚下圆点坐标
    bool IsGround, IsJump;
    public Animator anim;
    //动画组件

    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        IsGround = Physics2D.OverlapCircle(GroundCheck.position, 0.1f, Ground);
        if (IsGround) anim.SetBool("Jump", false);
        if (Input.GetButtonDown("Jump"))//是否按下跳跃
            IsJump = true;
        if (Input.GetButtonUp("Jump"))
            IsJump = false;
        if (Input.GetKeyDown("r")) Player.transform.eulerAngles = new Vector3(0, 0, 0);
        //按下左shift加速
        //    if (IsGround)
        //    {
        //        if (Input.GetKeyDown(KeyCode.LeftShift))
        //        {
        //            Speed *= 2;
        //            //设置是否在奔跑
        //        }
        //        if (Input.GetKeyUp(KeyCode.LeftShift))
        //        {
        //            Speed /= 2;
        //        }
        //    }
    }

    void FixedUpdate()
    {
        Movement();
        if (IsGround) anim.SetBool("Jump", false);

    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.tag == "collection")
    //    {
    //        Destroy(collision.gameObject);
    //        cherry++;
    //    }
    //    if(collision.tag == "enemy" && (Player.velocity.y >= -0.5))
    //    {
    //        Destroy(gameObject);
    //    }
    //    else if (collision.tag == "enemy" && (Player.velocity.y < -0.5))
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}

  

    void Movement()
    {
        //移动
        float move, face = Input.GetAxisRaw("Horizontal");
        move = Input.GetAxis("Horizontal");
        anim.SetFloat("Run", Mathf.Abs(move));
        //是否在移动
        Player.velocity = new Vector2(move * Speed * Time.fixedDeltaTime, Player.velocity.y);
        if (face != 0)
        {
            transform.localScale = new Vector3(face*3.5f, 3.5f, 3.5f);
        }
        //跳跃
        if (IsJump && IsGround)
        {
            IsJump = false;
            IsGround = false;
            anim.SetBool("Jump", true);
            Player.velocity = new Vector2(Player.velocity.x, JumpHigh);
        }
    }
}
