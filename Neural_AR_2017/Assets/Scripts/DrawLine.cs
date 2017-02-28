using UnityEngine;
using System.Collections;

public class DrawLine : MonoBehaviour {

	private LineRenderer lineRenderer;
	private float counter;
	private float dist;
	public Transform origin;
	public Transform destination;
	public float lineDrawSpeed = 6f;
	public float line_width = 0.1f;
	Vector3 newPos = new Vector3 (0, 0, 0);
	public Canvas canvas;

	// Use this for initialization
	void Start ()
	{
		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.SetPosition(0, origin .position);
		lineRenderer.SetWidth(line_width, line_width);
		dist = Vector3.Distance(origin.position, destination.position);
	}

	//Update is called once per framce
	void Update ()
	{
		//Rotate destination object to face camera
		canvas.transform.rotation = Camera.main.transform.rotation;

		newPos.x = destination.position.x - destination.GetComponent<RectTransform> ().rect.width/2;
		newPos.y =  destination.position.y - destination.GetComponent<RectTransform> ().rect.height/2;
		newPos.z = destination.position.z;
	
		//Debug.Log ("Dest.rot: " + destination.rotation.ToString());

		lineRenderer.SetPosition(0, origin.position);
		lineRenderer.SetPosition(1, destination.position);
	}
}