using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms;

public class GameManager : MonoBehaviour
{
    public BallMovement ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public Text playerScoreText;
    public Text computerScoreText;
    public Text ScoreText;
    public Text TimerText;
    private int _playerScore;
    private int _computerScore;

    public void Start()
    {
        ScoreText.enabled = false;
        TimerText.enabled = false;
    }
    public void PlayerScored()
    {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();
        StartRoundUI(3.0f, "Player");
        
    }

    public void ComputerScored()
    {
        _computerScore++;
        computerScoreText.text = _computerScore.ToString();
        StartRoundUI(3.0f, "Computer");
        

    }

    public void ResetRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();

    }

    public void StartRoundUI(float timeRemaining, string won)
    {
        StartCoroutine(RunRoundUI(timeRemaining, won));
    }

    public void LockAll()
    {
        ball.LockPosition();
        playerPaddle.LockPosition();
        computerPaddle.LockPosition();
    }

    public void UnlockAll()
    {
        ball.UnlockPosition();
        playerPaddle.UnlockPosition();
        computerPaddle.UnlockPosition();
    }

    private IEnumerator RunRoundUI(float timeRemaining, string won)
    {
        ResetRound();
        LockAll();

        ScoreText.enabled = true;
        TimerText.enabled = true;
        ScoreText.text = $"{won} won the round";

        while (timeRemaining > 0)
        {
            TimerText.text = timeRemaining.ToString("F0");
            timeRemaining -= Time.deltaTime;
            yield return null;
        }

        ScoreText.enabled = false;
        TimerText.enabled = false;
        UnlockAll();
        ball.AddStartingForce();
    }




}
