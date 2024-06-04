using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
	private const string PLAYER = "Player";
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag(PLAYER))
		{
			//Destroy the animal
			Destroy(gameObject);
		}
		else
		{
			//Destroy the animal
			Destroy(gameObject);
			Destroy(other.gameObject);
		}
	}
}
