using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    [Tooltip("平台移动结束位置")]
    public Transform stoptransform;
    [Tooltip("平台移动一次的时间")]
    public float moveTime = 1f;
    [Tooltip("平台移动到边界后的停止时间")]
    public float stayTime = 1f;

    private Vector3 stopPosition;
    private bool isToStopPoint = true;//是否朝向结束位置
    private float speed;//移动速度
    private Vector3 startPosition;//初始位置
    [SerializeField]
    private bool on = false;//平台移动开关


    // Start is called before the first frame update
    void Start()
    {
        stopPosition = stoptransform.position;
        startPosition = transform.position;//获取初始位置
        speed = Vector3.Distance(startPosition, stopPosition) / moveTime;//计算移动速度
    }

    // Update is called once per frame
    void Update()
    {
        startMove(on);//为什么要每一帧调用一次？因为这个方法不是一次性的把平台从起点
        //移动到重点，而是一次移动一小段距离，所以每一帧调用一次
    }
    /// <summary>
    /// 平台移动控制
    /// </summary>
    /// <param name="_on">平台移动开关</param>
    void startMove(bool _on)
    {
        if (!_on) { return; }//如果开关关闭，则停止移动
        StartCoroutine(platformMove(stopPosition));
    }

    IEnumerator platformMove(Vector3 stopPoisition)
    {
        Vector3 tempPosition = transform.position;
        if(isToStopPoint)
        {
            tempPosition = Vector3.MoveTowards(tempPosition, stopPoisition, speed * Time.deltaTime);
            transform.position = tempPosition;//将这个平台移动
            if(tempPosition == stopPoisition)//如果到达终点的话
            {
                yield return new WaitForSeconds(stayTime);//停下
                isToStopPoint = false;//反向行驶
            }
        }
        else if(!isToStopPoint)
        {
            tempPosition = Vector3.MoveTowards(tempPosition, startPosition, speed * Time.deltaTime);
            transform.position = tempPosition;
            if(tempPosition == startPosition)
            {
                yield return new WaitForSeconds(stayTime);//停下
                isToStopPoint = true;//反向行驶
            }

        }

    }
    //相对运动
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.SetParent(transform);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.transform.SetParent(null);
    }




    // 便于调试
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(stopPosition, transform.GetChild(0).localScale);
    }


}
