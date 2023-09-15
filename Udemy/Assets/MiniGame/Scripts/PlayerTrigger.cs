using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    [SerializeField]
    private Managers manager = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DeadZone")
        {
            manager.isGameOver = true;
        }

        if (other.gameObject.tag == "Finish")
        {
            manager.isGameClear = true;
        }
    }
}
