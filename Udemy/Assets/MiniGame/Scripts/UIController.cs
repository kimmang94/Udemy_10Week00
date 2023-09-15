using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Managers manager = null;
    [SerializeField] private Button retryBtn = null;
    [SerializeField] private Button startBtn = null;
    
    [SerializeField] private GameObject retryPanel = null;
    [SerializeField] private GameObject claerPanel = null;

    [SerializeField] private GameObject introPanel = null;
    // Start is called before the first frame update
    void Start()
    {
        startBtn.onClick.AddListener(StartBtn);
        retryBtn.onClick.AddListener(RetryBtn);
    }

    private void Update()
    {
        if (manager.isGameOver)
        {
            retryPanel.SetActive(true);
        }

        if (manager.isGameClear)
        {
            claerPanel.SetActive(true);
        }
    }

    private void StartBtn()
    {
        introPanel.SetActive(false);
        Time.timeScale = 1;
    }
    private void RetryBtn()
    {
        SceneManager.LoadScene("MiniGame");
        
        retryPanel.SetActive(false);
        claerPanel.SetActive(false);
    }
}
