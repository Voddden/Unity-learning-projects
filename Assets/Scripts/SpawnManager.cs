using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] animalPrefabs;
    public int animalCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalPrefabs[animalCount], new Vector3(0, 0, 30), animalPrefabs[animalCount].transform.rotation);
        }
    }
}
