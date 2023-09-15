using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    
    [SerializeField]
    private GameObject[] wallPrefab;

    private float interval = 0.5f;

    private float range = 3;
    
    private float term;

    private void Start()
    {
        term = interval;
    }

    private void Update()
    {
        Spawn();
    }

    /// <summary>
    /// 프리팹을 생성하는 메서드
    /// </summary>
    private void Spawn()
    {
        term += Time.deltaTime;
        if (term >= interval)
        {
            Vector3 pos = transform.position;
            pos.y += Random.Range(-range, range);
            int wallType = Random.Range(0, wallPrefab.Length);
            Instantiate(wallPrefab[wallType], pos, transform.rotation);
            term -= interval;
        }
    }
}
