using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastClickTime;
    
    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastClickTime > 1.0f)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                lastClickTime = Time.time;
            }
        }
    }
}
