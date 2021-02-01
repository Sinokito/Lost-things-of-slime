using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OneToTwo : MonoBehaviour
{
    [Header("需要切换的场景")]
    public int ScenseInt;
    //淡入淡出速度
    [Header("淡入淡出速度")]
    public float FaderSpeed;
    public Image image;
    //判断场景切换是否结束
    bool scenseStar = true;

    public GameObject TriggerUse;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            TriggerUse.SetActive(true);
            Destroy(gameObject, 0.1f);
        }
    }
    void StarScense()
    {
        image.color = Color.Lerp(image.color, Color.clear, FaderSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (scenseStar)
        {
            StarScense();
        }       
    }
}
