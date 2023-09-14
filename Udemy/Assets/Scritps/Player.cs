using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float jumpPower = 5f;

    public float moveSpeed = 1;
    private TextMesh scoreOutPut;
    private int score = 0;

    private float doubleJumpPower = 2;
    private float DangerPos = -3;
    void Start()
    {
        scoreOutPut = GameObject.Find(name: "Score").GetComponent<TextMesh>();
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
            if (gameObject.transform.position.y <= DangerPos)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower * doubleJumpPower, 0);
            }

            

        }
       // transform.localScale += new Vector3(0, 0.002f, 0.0f);
        //transform.Translate(moveSpeed * Time.deltaTime , 0, 0);
    }

    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void Addscore(int s)
    {
        score += s;
        scoreOutPut.text = "점수 : " + score;
    }
}


