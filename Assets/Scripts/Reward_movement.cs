using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward_movement : MonoBehaviour {

	public float speed = 2.0f;
	public int Edirection = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 oldpos = gameObject.transform.position;
		Vector3 newpos = new Vector3(oldpos.x + (Edirection*speed * Time.deltaTime), oldpos.y, oldpos.z);
		transform.position = newpos;
		
	}
	void OnCollisionEnter2D(Collision2D colli)
	{
		//Debug.Log("asd");
		if (colli.gameObject.tag == "obstacle")
		{
			Edirection *= -1;
		}
		if(colli.gameObject.tag == "Player")
        {
			Destroy(gameObject);
        }
		

	}
}
