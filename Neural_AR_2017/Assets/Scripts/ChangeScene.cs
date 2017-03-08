using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public int sceneNum;
	public bool autoTimer = false;
	public float timeLeft = 5.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (autoTimer) {
			//Debug.Log ("AUTOTIMER ON");
			timeLeft -= Time.deltaTime;
			if(timeLeft < 0)
			{
				changeScene ();

			}
		}
	}

	public void changeScene(){
		SceneManager.LoadScene (sceneNum);

	}
}
