using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	private const string SPAWN_RANDOM_ANIMAL_UPPER = "SpawnRandomAnimalUpper";
	private const string SPAWN_RANDOM_ANIMAL_LEFT = "SpawnRandomAnimalLeft";
	private const string SPAWN_RANDOM_ANIMAL_RIGHT = "SpawnRandomAnimalRight";

	[SerializeField] private GameObject[] animalsPrefabs;


	[SerializeField] private float startDelay = 2;
	[SerializeField] private float repeatDelay = 1.5f;


	private void Start()
	{
		InvokeRepeating(SPAWN_RANDOM_ANIMAL_UPPER, startDelay, repeatDelay);
		InvokeRepeating(SPAWN_RANDOM_ANIMAL_LEFT, startDelay, repeatDelay);
		InvokeRepeating(SPAWN_RANDOM_ANIMAL_RIGHT, startDelay, repeatDelay);

	}

	// Update is called once per frame
	private void Update()
	{

	}

	private void SpawnRandomAnimalUpper()
	{
		float spawnRangeX = 17;
		float spawnRangeZ = 20;
		int animalIndex = Random.Range(0, animalsPrefabs.Length);
		Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

		Instantiate(animalsPrefabs[animalIndex], spawnPosition, animalsPrefabs[animalIndex].transform.rotation);
	}

	private void SpawnRandomAnimalLeft()
	{
		float spawnRangeZLeft = 4;
		float spawnRangeZRight = 20;
		float spawnPosX = 26;

		int animalIndex = Random.Range(0, animalsPrefabs.Length);

		Vector3 rotation = new Vector3(0, 90, 0);
		Vector3 spawnPosition = new Vector3(-spawnPosX, 0, Random.Range(spawnRangeZLeft, spawnRangeZRight));

		Instantiate(animalsPrefabs[animalIndex], spawnPosition, Quaternion.Euler(rotation));
	}

	private void SpawnRandomAnimalRight()
	{
		float spawnRangeZLeft = 4;
		float spawnRangeZRight = 20;
		float spawnPosX = 26;

		int animalIndex = Random.Range(0, animalsPrefabs.Length);

		Vector3 rotation = new Vector3(0, -90, 0);
		Vector3 spawnPosition = new Vector3(spawnPosX, 0, Random.Range(spawnRangeZLeft, spawnRangeZRight));

		Instantiate(animalsPrefabs[animalIndex], spawnPosition, Quaternion.Euler(rotation));
	}

}
