using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private float horizontalInput;
	[SerializeField] private float movSpeed;
	[SerializeField] private float xRange;
	
	[SerializeField] private GameObject projectilePrefab;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//Keep the player in the limits of the screen
		if (transform.position.x < -xRange)
		{
			transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
		}
		
		if (transform.position.x > xRange)
		{
			transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
		}
		
		horizontalInput = Input.GetAxis("Horizontal");
		transform.Translate(horizontalInput * movSpeed * Time.deltaTime * Vector3.right);
		
		//Instantiate a projectile prefab
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
		}
	}
}
