using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
	public GameObject dogPrefab;

	private float spawnCooldown = 1.5f;
	private float lastSpawnTime;
	// Start is called before the first frame update
	void Start()
	{
		lastSpawnTime = -spawnCooldown;
	}
	// Update is called once per frame
	void Update()
	{
		if (Time.time - lastSpawnTime >= spawnCooldown)
		{
			// On spacebar press, send dog
			if (Input.GetKeyDown(KeyCode.Space))
			{
				Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
				lastSpawnTime = Time.time; // Atualiza o tempo do último spawn
			}
		}
	}
}
