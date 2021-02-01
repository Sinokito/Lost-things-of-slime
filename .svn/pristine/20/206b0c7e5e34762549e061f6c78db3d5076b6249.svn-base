using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// @author：BkB
/// @time：2021/1/26
/// @概述：定期扫描，disable掉未播放的音效节点
/// 
/// </summary>
public class sound_scan : MonoBehaviour
{
    private AudioMgr audioMgr;
    // Start is called before the first frame update
    void Start()
    {
        //每一点五秒执行一次scan
        this.InvokeRepeating("scan", 0, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void scan()
    {
        audioMgr.disable_over_audio();
    }

    public void setAudioMgr(AudioMgr a)
    {
        audioMgr = a;
    }


}
