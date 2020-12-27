using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public int addedScore;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        FindObjectOfType<GameManager>().playingEvent += ScoreUp;
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
}
