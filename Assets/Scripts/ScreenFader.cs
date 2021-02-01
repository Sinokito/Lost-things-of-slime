﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenFader : MonoBehaviour
{
    [Header ("需要切换的场景")]
    public int ScenseInt;
    //淡入淡出速度
    [Header ("淡入淡出速度")]
    public float FaderSpeed;
    public Image image;
    //判断场景切换是否结束
    bool scenseStar = true;
    bool scenseEnd = false;

    public void dwdwa()
    {
        scenseEnd = true;
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
        image.color = Color.Lerp(image.color, Color.clear, FaderSpeed*Time.deltaTime);
    }
    void EndScense()
    {
        image.color = Color.Lerp(image.color, Color.black, FaderSpeed * Time.deltaTime);
        if (image.color.a > 0.45f)
        {
            SceneManager.LoadScene(ScenseInt);
        }
    }
}
//东曦
//1.30 - 13.10
