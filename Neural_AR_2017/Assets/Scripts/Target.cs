using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	public GameObject ARcam;
	private float n1;
	private float n2;
	private float n3;
	private float x;
	private float y;
	private float z;

	
	// Update is called once per frame
	void Update () {
	
		Vector3 pos = ARcam.transform.position;
		Vector3 pos2 = ARcam.transform.eulerAngles;

		n1 = (pos.y / (Mathf.Tan (pos2.x / 57.3f)));
		n2 = pos.x / (n1 * Mathf.Sin(pos2.y / 57.3f));
		n3 = pos.z / (n1 * Mathf.Cos(pos2.y / 57.3f));


		x = x + (n2 - x);
		z = z + (n3 - z);

		transform.position = new Vector3 (x, 0, z);
	}
}
