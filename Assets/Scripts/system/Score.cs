using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public int bestScore;
    public int addedScore;
    public Text endScoreText;
    public Text bestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        FindObjectOfType<GameManager>().playingEvent += ScoreUp;
        FindObjectOfType<GameManager>().overEvent += OverEvent;
        FindObjectOfType<GameManager>().restartEvent += RestartEvent;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        score += addedScore;
    }

    void ScoreUp()
    {
        addedScore = 1;
    }
    void OverEvent()
    {
        addedScore = 0;
        if (score > bestScore)
            bestScore = score;
        bestScoreText.text = bestScore.ToString();
        endScoreText.text = score.ToString();
    }

    void RestartEvent()
    {
        score = 0;
    }
}
