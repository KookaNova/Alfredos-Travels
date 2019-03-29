using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public FloatData Score;
    public Text ScoreText;

    void Start()
    {
        SetScoreText();
    }

    void SetScoreText()
    {
        ScoreText.text = "Score: " + Score.Value;
    }

    void Update()
    {
        ScoreText.text = "Score: " + Score.Value;
    }
}
