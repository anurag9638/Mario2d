using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Coin : MonoBehaviour {
	public AudioSource coinSound;
	
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D colli)
	{
		//Debug.Log("asd");
		if (colli.gameObject.tag == "Player")
		{
			coinSound.Play();

			Destroy(gameObject);
		}
		

	}
	
}
