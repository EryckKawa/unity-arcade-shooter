using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int score;
    private int lives;

    public static event Action<int> OnScoreChanged;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        OnScoreChanged?.Invoke(score);
    }

    public void AddLives(int amount)
    {
        lives += amount;
        // Atualizar UI de vidas se necessário
    }

    public int GetScore()
    {
        return score;
    }

    public int GetLives()
    {
        return lives;
    }
}
