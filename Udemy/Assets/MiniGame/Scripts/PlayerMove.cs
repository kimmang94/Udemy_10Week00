using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Animator anim = null;
    [SerializeField] private Rigidbody rigid;
    private float speed = 5f;
    [SerializeField] private float jumpPower = 3f;
    [SerializeField]private bool isJumping = false;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.3f);
            transform.position += ((Vector3.left * (Time.deltaTime * speed)));
            anim.SetBool("isRun", true);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.3f);
            transform.position += ((Vector3.right * (Time.deltaTime * speed)));
            anim.SetBool("isRun", true);
        }
        
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetBool("isRun", false);
            anim.SetBool("Wait", true);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("isRun", false);
            anim.SetBool("Wait", true);
        }
        
        if (Input.GetButtonDown("Jump") )
        {
            rigid.velocity = new Vector3(0, jumpPower, 0);
            {
                anim.SetBool("isJump", true);
                rigid.velocity = new Vector3(0, jumpPower ,0);
            }
            
        }
        anim.SetBool("isJump", false);
    }

}
