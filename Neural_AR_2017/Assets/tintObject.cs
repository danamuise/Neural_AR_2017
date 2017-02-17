using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tintObject : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DropDown_IndexChanged(int index){

		if (index == 0)
			Tint_non ();

		if (index == 1)
			Tint_red ();
		
		if (index == 2)
			Tint_green ();

		if (index == 3)
			Tint_blue ();



	}

	public void Tint_non(){
		Color color = Color.white;
		GetComponent<Renderer>().material.color = color;
	}
	public void Tint_red(){
		Color color = Color.red;
		GetComponent<Renderer>().material.color = color;
	}
	public void Tint_green(){
		Color color = Color.green;
		GetComponent<Renderer>().material.color = color;
	}
	public void Tint_blue(){
		Color color = Color.blue;
		GetComponent<Renderer>().material.color = color;
	}
}
