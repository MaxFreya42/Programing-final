using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private Rigidbody _platform;
    int counter = 20;
    int random;
    float nextX = 2;
    float nextZ = 2;
    
    
    void Start()
    {
       
        while (counter > 0)
        {
            Vector3 location = new Vector3(nextX, nextZ, 0f);
            int random = Random.Range(0, 1);
            if (random == 1)
            {
                Instantiate(_platform);
                gameObject.transform.position = gameObject.transform.position + location;
                nextX += 2;
                
            }
            else if (random == 0)
            {
                Instantiate(_platform);
                gameObject.transform.position = gameObject.transform.position + location;
                nextZ += 2;
            }
            counter -= 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
