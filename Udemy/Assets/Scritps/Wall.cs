using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour
{

    private float speed = -5f;
    private Player player;
    private  void Start()
    {
        player = GameObject.Find(name: "Player").GetComponent<Player>();
    }

    private  void Update()
    {
        transform.Translate(speed * Time.deltaTime , 0, 0);
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
            player.Addscore(1);
            Debug.Log("Destroy Test");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("Scenes/Game");
    }
}
