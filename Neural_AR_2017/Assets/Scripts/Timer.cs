using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	public float timeLeft = 5.0f;

	Text text;

	void Awake ()
	{

	}

	void Update()
	{
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0)
		{
			StartCoroutine (changeScene ());

		}
	}

	IEnumerator changeScene(){
		yield return new WaitForSeconds(5);
		SceneManager.LoadScene ("mainScene");
	}
}