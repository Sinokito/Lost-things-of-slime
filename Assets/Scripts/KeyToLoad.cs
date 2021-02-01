using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeyToLoad : MonoBehaviour
{
    [Header("需要切换的场景")]
    public int ScenseInt;
    [Header("淡入淡出速度")]
    public float FaderSpeed;
    public Image image;
    bool scenseEnd = false;

    private void OnEnable()
    {
        scenseEnd = true;
    }
    void EndScense()
    {
        image.color = Color.Lerp(image.color, Color.black, FaderSpeed * Time.deltaTime);
        if (image.color.a > 0.65f)
        {
            SceneManager.LoadScene(ScenseInt);
        }
    }
    private void Update()
    {
        if (scenseEnd)
        {
            EndScense();
        }
    }
}
