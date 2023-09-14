using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float jumpPower = 5f;
    [SerializeField]
    private float moveSpeed = 1;

    private TextMesh scoreOutPut;
    private int score = 0;
    private float doubleJumpPower = 2;
    private float DangerPos = -3;

    [SerializeField] private Rigidbody rigid;
    
    private void Start()
    {
        scoreOutPut = GameObject.Find("Score").GetComponent<TextMesh>();
        rigid = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        Jump();
    }

    /// <summary>
    /// 점프를 위한 메서드
    /// </summary>
    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.velocity = new Vector3(0, jumpPower, 0);
            if (gameObject.transform.position.y <= DangerPos)
            {
                rigid.velocity = new Vector3(0, jumpPower * doubleJumpPower, 0);
            }
        }
        // transform.localScale += new Vector3(0, 0.002f, 0.0f);
        //transform.Translate(moveSpeed * Time.deltaTime , 0, 0);
    }

    /// <summary>
    /// 매개변수 int형 s를 받아 s 만큼 점수를 증가시키는 메서드
    /// </summary>
    /// <param name="s"></param>
    
    public void Addscore(int s)
    {
        score += s;
        scoreOutPut.text = "점수 : " + score;
    }
    
    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


