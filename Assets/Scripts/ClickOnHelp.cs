using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickOnHelp : MonoBehaviour {

	public Button yourButton;

	// Use this for initialization
	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	void TaskOnClick()
	{
		SceneManager.LoadScene("Help");
	}
	// Update is called once per frame
	void Update()
	{

	}
}
