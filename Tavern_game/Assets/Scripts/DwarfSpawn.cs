using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwarfSpawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject spawnToObject;
    // Start is called before the first frame update
    // void Start()
    // {
    //     Instantiate(objectToSpawn, spawnToObject.transform);
    // }
    void Update() 
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            //Destroy(objectToSpawn);
            Instantiate(objectToSpawn, spawnToObject.transform);
        }
    }
}
