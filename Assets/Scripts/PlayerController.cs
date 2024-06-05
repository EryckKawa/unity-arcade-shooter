using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private float horizontalInput;
	private float verticalInput;

	[SerializeField] private float movSpeed;
	[SerializeField] private float xRange;
	[SerializeField] private float zRangeUpper;
	[SerializeField] private float zRangeBottom;

	[SerializeField] private GameObject projectilePrefab;
	[SerializeField] private Transform projectileSpawnPoint;

	// Update is called once per frame
	void Update()
	{
		HandleMovement();
		HandleShooting();
		KeepPlayerWithinLimits();
	}

	private void HandleMovement()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		verticalInput = Input.GetAxis("Vertical");

		Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);

		if (movementDirection != Vector3.zero)
		{
			movementDirection = movementDirection.normalized;

			float rotateSpeed = 7f;
			transform.forward = Vector3.Slerp(transform.forward, movementDirection, Time.deltaTime * rotateSpeed);
		}

		transform.Translate(movementDirection * movSpeed * Time.deltaTime, Space.World);
	}

	private void HandleShooting()
	{
		//Instantiate a projectile prefab
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			Instantiate(projectilePrefab, projectileSpawnPoint.transform.position, transform.rotation);
		}
	}

	private void KeepPlayerWithinLimits()
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
		if (transform.position.z > zRangeUpper)
		{
			transform.position = new Vector3(transform.position.x, 0, zRangeUpper);
		}
		if (transform.position.z < zRangeBottom)
		{
			transform.position = new Vector3(transform.position.x, 0, zRangeBottom);
		}
	}

}
