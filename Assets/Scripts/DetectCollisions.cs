using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
	private const string PLAYER = "Player";
	private const string ANIMAL = "Animal";

	private int scoreIncrement = 10;
	private int livesDecrement = -1;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag(PLAYER))
		{
			GameManager.Instance.AddLives(livesDecrement);
			Destroy(gameObject);
		}
		else if (other.CompareTag(ANIMAL))
		{
			GameManager.Instance.AddScore(scoreIncrement);
			Destroy(gameObject);
			Destroy(other.gameObject);
		}
	}
}
