using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Panels panels;
    public enum GameStatus
    {
        start,
        playing,
        over,
    }
    public GameStatus gameStatus;
    public Action playingEvent;
    public Action overEvent;
    public Action restartEvent;

    // Start is called before the first frame update
    void Start()
    {
        gameStatus = GameStatus.start;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            GameOver();
    }
    public void OnClickStart()
    {
        gameStatus = GameStatus.playing;
        playingEvent?.Invoke();
        panels.startPanel.SetActive(false);
        panels.playingPanel.SetActive(true);
    }

    public void GameOver()
    {
        gameStatus = GameStatus.over;
        overEvent?.Invoke();
        panels.overPanel.SetActive(true);
        panels.playingPanel.SetActive(false);
    }
    public void OnClickRestart()
    {
        gameStatus = GameStatus.start;
        restartEvent?.Invoke();
        panels.overPanel.SetActive(false);
        panels.startPanel.SetActive(true);
    }
}
