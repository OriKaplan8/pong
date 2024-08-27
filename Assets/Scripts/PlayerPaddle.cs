using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerPaddle : Paddle
{
    

    private void Update()
    {
        moveDirection = new Vector2(0, Input.GetAxis("Vertical"));
        
    }

    


}
