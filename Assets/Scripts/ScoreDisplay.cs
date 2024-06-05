using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
	[SerializeField] private TMP_Text scoreText;

    private void OnEnable()
    {
        GameManager.OnScoreChanged += UpdateScore;
    }

    private void OnDisable()
    {
        GameManager.OnScoreChanged -= UpdateScore;
    }

    private void UpdateScore(int newScore)
    {
        scoreText.text = "Score: " + newScore;
    }
}

