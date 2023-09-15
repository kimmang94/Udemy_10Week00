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
    
    private void Update()
    {
        Move();
        transform.Translate(0, 0, speed * Time.deltaTime);
        anim.SetBool("isRun", true);
        anim = GetComponent<Animator>();
    }

    private void Move()
    {
        anim.SetTrigger("Wait");

        if (Input.GetKeyUp(KeyCode.LeftArrow)){
            transform.rotation = Quaternion.Euler(0, 270, 0);
            
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow)){
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            isJumping = true;
            rigid.velocity = new Vector3(0, jumpPower, 0);
            {
                rigid.velocity = new Vector3(0, jumpPower ,0);
            }
        }

    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
    }
}
