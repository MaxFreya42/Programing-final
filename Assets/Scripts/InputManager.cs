using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static PlayerController _controls;


    public static void Init(BallController myPlayer)
    {
        _controls = new PlayerController();


        _controls.MainGamePlay.Begin.performed += ctx =>
        {
            myPlayer.AllowMove();

        };

    }
    public static void GameMode()
    {
        _controls.MainGamePlay.Enable();

    }
}
