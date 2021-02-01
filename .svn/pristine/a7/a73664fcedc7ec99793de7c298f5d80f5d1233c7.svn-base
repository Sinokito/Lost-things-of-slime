using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// @author:BkB
/// @time:2021/1/28
/// @概述：实现声音大小调整和静音功能
/// </summary>
public class AudioUI : MonoBehaviour
{
    public AudioMgr AudioMgr;
    public AudioUI audioUI;
    //调整音量
    private Slider slider;
    //音效开关
    private Toggle toggle;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponentInChildren<Slider>();//获得组件
        toggle = GetComponentInChildren<Toggle>();//获得组件
        //默认值设定
        slider.value = .5f;
        toggle.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        slider.onValueChanged.AddListener(value=>
        {
            AudioMgr.setVolume(value);//音量大小实时调整
        });

        toggle.onValueChanged.AddListener(bState =>
        {
            AudioMgr.setMute(bState);//实时调整音量开关
        }
        );

    }

    
    
}
