using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	public GameObject player;
	public float min_X;
	public float min_Y;
	public float max_X;
	public float max_Y;
	public AudioSource theme;
	public float abc;


	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		

		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Mathf.Clamp(player.transform.position.x+3, min_X, max_X);
		float y = Mathf.Clamp(player.transform.position.y, min_Y, max_Y);
		gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
		if(abc ==10)
        {
			theme_stop();
        }


	}

	 public void theme_stop()
    {
		theme.Stop();

    }
}
