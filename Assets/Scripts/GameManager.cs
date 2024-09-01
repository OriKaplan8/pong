using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BallMovement ball;
    public Text playerScoreText;
    public Text computerScoreText;
    private int _playerScore;
    private int _computerScore;


    public void PlayerScored()
    {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();
        ball.ResetPosition();
        ball.AddStartingForce();

    }

    public void ComputerScored()
    {
        _computerScore++;
        computerScoreText.text = _computerScore.ToString();
        ball.ResetPosition();
        ball.AddStartingForce();

    }
}
