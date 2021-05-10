using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardBoxDestroy : MonoBehaviour
{
	public int damage = 0;
	public GameObject mushroom;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		
		if (damage >= 8)
        {
			Destroy(gameObject);
        }

	}
	void OnCollisionEnter2D(Collision2D colli)
	{
		//Debug.Log("asd");
		if (colli.gameObject.tag == "Player")
		{
			GetComponent<Rigidbody2D>().AddForce(Vector3.up * 400);
			damage++;

		}
		if (damage >= 3)
		{

			//mushroom.SetActive(true);
		}


	}
}
