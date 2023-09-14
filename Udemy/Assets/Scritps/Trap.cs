using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{

    private void Update()
    {
        if (gameObject.transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
    }
}
