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

    // Start is called before the first frame update
    void Start()
    {
        gameStatus = GameStatus.start;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickStart()
    {
        gameStatus = GameStatus.playing;
        playingEvent?.Invoke();
        panels.startPanel.SetActive(false);
        panels.playingPanel.SetActive(true);
    }
}
