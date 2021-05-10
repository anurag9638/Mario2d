using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	public float EnemySpeed = 5.0f;
	public int Edirection = 1;
	private int damage = 0;
	public bool dead= false;

	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		Vector3 enemypos = gameObject.transform.position;
		if (dead == false)
		{
			Vector3 newpos = new Vector3(enemypos.x + (Edirection * EnemySpeed * Time.deltaTime), enemypos.y, enemypos.z);
			transform.position = newpos;
		}
		if (damage >1)
        {
			
			GetComponent<BoxCollider2D>().enabled = false;
			dead = true;
			
        }



	}
	void OnCollisionEnter2D(Collision2D colli)
	{
		//Debug.Log("asd");
		if (colli.gameObject.tag == "obstacle")
		{
			Edirection *= -1;
		}
		if(colli.gameObject.tag == "Weapon")
        {
			damage++;
        }
		if(colli.gameObject.tag == "Weapon" && damage >1)
        {
			GetComponent<Rigidbody2D>().AddForce(Vector3.up * 310);
		}
		
	}
	IEnumerator Coroutine1()
	{

		yield return new WaitForSeconds(2);
		Destroy(gameObject);

		yield return 0;
	}

}