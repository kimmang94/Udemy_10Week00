using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private Player player = null;
    private float speed = 3;
    
    private void Update()
    {
        transform.Translate(-speed * Time.deltaTime , 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("아이템 획득");
            Destroy(gameObject);
            player.Addscore(1);
        }
    }
}
