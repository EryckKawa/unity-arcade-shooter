using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] private int lifes;
	[SerializeField] private int score;

	public static GameManager Instance { get; private set; }

	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(gameObject);  // Se já existe uma instância, destrua este objeto
		}
	}

	public void AddLives(int value)
	{
		lifes += value;
		if (lifes <= 0)
		{
			lifes = 0;
		}
	}

	public void AddScore(int value)
	{
		score += value;
	}

	public int GetLives()
	{
		return lifes;
	}

	public int GetScore()
	{
		return score;
	}
}
