using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour {
	public int damage=0;
	public float Jump_force = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(damage>=6)
        {
			Destroy(gameObject);
        }
		
	}
	void OnCollisionEnter2D(Collision2D colli)
	{
		if (colli.gameObject.tag == "Player")
		{
			GetComponent<Rigidbody2D>().AddForce(Vector3.up * 400);

			//Debug.Log("asd");
			damage++;
		}
		


	}
}
