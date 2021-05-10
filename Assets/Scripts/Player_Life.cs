using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Life : MonoBehaviour {
	public float health;
	public bool hasDied;
	public bool deathTimer;
	public Animator anim;
	public AudioSource died_audio;
	public AudioSource themea;
	


	// Use this for initialization 

	void Start () {
		hasDied = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.y < -12)
        {
			hasDied = true;
        }

		if (hasDied == true)
		{
			StartCoroutine(Coroutine1());
			if (deathTimer == true)
			{
				Debug.Log("Player has DIED");
				SceneManager.LoadScene("RestartMenu");

			}
		}
		
	}
	void OnCollisionEnter2D (Collision2D colli)
    {
		CameraMovement obj = new CameraMovement();
		if (colli.gameObject.tag == "enemy")
        {
			themea.Stop();
			
			died_audio.Play();
			anim.SetFloat("Dead", 2);
			GetComponent<Rigidbody2D>().AddForce(Vector3.up * 450);
			hasDied = true;
			
			GetComponent<BoxCollider2D>().enabled = false;
			obj.theme_stop();
			

		}
    }
	IEnumerator Coroutine1()
	{
		
		yield return new WaitForSeconds(3);

		deathTimer = true;
        yield return 0;
    }
}
