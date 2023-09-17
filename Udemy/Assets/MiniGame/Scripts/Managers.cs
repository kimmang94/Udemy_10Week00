using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instance; 
    private static Managers Instance     
    { 
        get
        {
            Init(); return s_instance; 
        } 
    } 
    
    public bool isGameOver = false;
    public bool isGameClear = false;

    private void Awake()
    {
        Time.timeScale = 0;
    }

    private void Start()
    {
        Init();
    }
    private void Update()
    {
        if (isGameOver || isGameClear)
        {
            Time.timeScale = 0;
        }
    }
    
    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("Managers");
            if (go == null)
            {
                go = new GameObject { name = "Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }
       
    }
}
