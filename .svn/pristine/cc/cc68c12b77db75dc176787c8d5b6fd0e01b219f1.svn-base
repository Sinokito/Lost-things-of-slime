using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TwoToStart : MonoBehaviour
{
    [Header("过关Text")]
    public GameObject Cong;
    [Header("需要切换的场景")]
    public int ScenseInt;
    //淡入淡出速度
    [Header("淡入淡出速度")]
    public float FaderSpeed;
    public Image image;
    //判断场景切换是否结束
    bool scenseStar = true;
    bool scenseEnd = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            scenseEnd = true;
            Destroy(Cong, 2f);
        }
    }
    void Update()
    {
        if (scenseStar)
        {
            StarScense();
        }
        if (scenseEnd)
        {
            EndScense();
        }
    }
    void StarScense()
    {
        image.color = Color.Lerp(image.color, Color.clear, FaderSpeed * Time.deltaTime);
    }
    private void EndScense()
    {
        image.color = Color.Lerp(image.color, Color.black, FaderSpeed * Time.deltaTime);
        if (image.color.a > 0.5f)
        {
            SceneManager.LoadScene(ScenseInt);
        }        
    }
}
