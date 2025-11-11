using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    // private void Update()
    // {
    //     if (gameObject.transform.position.y < 0)
    //     {
    //         Destroy(gameObject);
    //         Debug.Log("GAME OVER");
    //     }
    // }
}
