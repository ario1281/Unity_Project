using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    private TMP_Text scoreText;
    private int score = 0;

    void Start()
    {
        GameObject.Find("Score").TryGetComponent(out scoreText);
    }

    void Update()
    {
        var text = "SCORE:" + score.ToString().PadLeft(10);
        scoreText.SetText(text);
    }
}
