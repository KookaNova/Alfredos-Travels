using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public FloatData Score;
    public Text ScoreText;

    void Update()
    {
        ScoreText.text = "" + Score.Value;
    }
}
