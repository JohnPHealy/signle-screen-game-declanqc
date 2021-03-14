using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 startPos;
    private int score;
    [SerializeField] private UnityEvent<string> addScore;

    private void Start()
    {
        startPos = player.transform.position;
        score = 0;
        UpdateUi();
        Time.timeScale = 0;
    }

    public void respawnPlayer()
    {
        player.transform.position = startPos;
        score = 0;
        UpdateUi();

    }

    public void AddScore(int scoreAmt)
    {
        score += scoreAmt;
        UpdateUi();
    }

    private void UpdateUi()
    {
        addScore.Invoke(score.ToString());
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1;
    }

}
