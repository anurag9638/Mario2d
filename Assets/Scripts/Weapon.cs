using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	public float bullet_speed = 10f;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Vector3 bullet_pos = transform.position;

		Vector3 newpos = new Vector3(bullet_pos.x + (bullet_speed * Time.deltaTime), bullet_pos.y, bullet_pos.z);
		transform.position = newpos;

	}
	void OnCollisionEnter2D(Collision2D colli)
	{
		//Debug.Log("asd");
		Destroy(gameObject);
		if(colli.gameObject.tag == "obstacle")
        {
			Destroy(gameObject);
        }
	


	}
}
