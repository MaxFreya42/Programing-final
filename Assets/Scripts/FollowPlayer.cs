using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform Player;
    private void Update()
    {       if (Player.transform.position.y > 0)
        {
            transform.position = Player.transform.position;
        }
    }

    
        
    
}
