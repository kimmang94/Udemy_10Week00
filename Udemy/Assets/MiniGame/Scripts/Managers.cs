using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    public bool isGameOver = false;
    public bool isGameClear = false;

    private void Update()
    {
        if (isGameOver || isGameClear)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
