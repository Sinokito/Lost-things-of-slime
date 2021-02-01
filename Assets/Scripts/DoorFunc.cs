using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorFunc : MonoBehaviour
{
    public GameObject colider;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetBool("isCover")) colider.SetActive(false);
        else colider.SetActive(true);
    }
}
