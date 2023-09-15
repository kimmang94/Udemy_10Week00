using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Managers manager;
    [SerializeField] private Button retryBtn = null;

    [SerializeField] private GameObject retryPanel = null;
    [SerializeField] private GameObject claerPanel = null;
    // Start is called before the first frame update
    void Start()
    {
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

    private void RetryBtn()
    {
        SceneManager.LoadScene("MiniGame");
        retryPanel.SetActive(false);
        claerPanel.SetActive(false);
    }
}
