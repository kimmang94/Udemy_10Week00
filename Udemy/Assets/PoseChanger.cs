using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseChanger : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim = null;
    void Start()
    {
        anim = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (anim == null)
            {
                anim = GetComponent<Animator>();
            }
            else
            {
                anim.SetTrigger("Next");
            }
        }
    }
}
