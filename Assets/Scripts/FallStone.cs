using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallStone : MonoBehaviour
{
    Vector3 start;
    public double limt;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        start = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //石头过低重置
        if (gameObject.transform.position.y < limt)
        {
            gameObject.transform.position = start;
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }
}
