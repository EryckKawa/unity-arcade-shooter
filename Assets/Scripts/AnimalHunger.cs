using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
	[SerializeField] private Slider hungerSlider;
	[SerializeField] private int amountToFeed;
	private int currentFedAmount = 0;

	// Start is called before the first frame update
	private void Start()
	{
		hungerSlider.maxValue = amountToFeed;
		hungerSlider.value = 0;
		hungerSlider.fillRect.gameObject.SetActive(false);
	}

	public void FeedAnimal(int amount)
	{
		currentFedAmount += amount;
		hungerSlider.fillRect.gameObject.SetActive(true);
		hungerSlider.value = currentFedAmount;
		
		if (currentFedAmount >= amountToFeed)
		{
			GameManager.Instance.AddScore(amountToFeed);
			Destroy(gameObject, 0.1f);
		}
	}
}
