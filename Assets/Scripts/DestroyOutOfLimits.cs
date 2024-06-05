using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfLimits : MonoBehaviour
{
	private float topLimit = 30;
	private float bottomLimit = -10;
	private float rightLimit = 27;
	private float leftLimit = -27;

	// Update is called once per frame
	private void Update()
	{
		if (transform.position.z > topLimit)
		{
			Destroy(gameObject);
		}
		else if (transform.position.z < bottomLimit)
		{
			Destroy(gameObject);
		}
		else if (transform.position.x < leftLimit)
		{
			Destroy(gameObject);
		}
		else if (transform.position.x > rightLimit)
		{
			Destroy(gameObject);
		}
	}
}
