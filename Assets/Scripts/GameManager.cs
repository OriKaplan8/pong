using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;


    public void PlayerScored()
    {
        _playerScore++;
    }

    public void ComputerScored()
    {
        _computerScore++;
    }
}
