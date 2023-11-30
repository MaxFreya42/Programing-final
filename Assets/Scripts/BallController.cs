using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float moveSpeed;
    private static Transform camFollow;

    bool _directionChange = false;
    
    public static int loseCon;
    


    void Start()
    {
        InputManager.Init(myPlayer: this);
        InputManager.GameMode();
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (loseCon != 0)
        {
            if (_directionChange)
            {

                rb.velocity = new Vector3(moveSpeed, 0f, 0f);
            }
            else if (!_directionChange)
            {
                rb.velocity = new Vector3(0f, 0f, moveSpeed);
            }
        }
        else if (loseCon == 0)
        {
            rb.velocity = new Vector3(0f, -15f, 0f);
            
        }
}

   

    public void AllowMove()
    {
        if (!_directionChange) 
        { 
            _directionChange = true;
        }
        else if (_directionChange)
        {
            _directionChange = false;
        }
        
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "SafeZone")
        {
            loseCon -= 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "SafeZone")
        {
            loseCon += 1;
        }
    }

    
}
