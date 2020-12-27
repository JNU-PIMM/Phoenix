using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauge : MonoBehaviour
{
    public Image bar;
    public float maxGauge;
    public float currentGauge;
    // Start is called before the first frame update
    void Start()
    {
        currentGauge = maxGauge;
        FindObjectOfType<GameManager>().playingEvent += ResetGauge;
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = currentGauge / maxGauge;
    }
    void ResetGauge()
    {
        currentGauge = maxGauge;
    }
}
