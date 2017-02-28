using UnityEngine;

public class DrawLine : MonoBehaviour {


	private LineRenderer lineRenderer;
	public Transform origin;
	public Transform destination;
	public float line_width = 0.01f;

	// Use this for initialization
	void Start ()
	{
		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.SetWidth(line_width, line_width);
		lineRenderer.SetColors (Color.white, Color.white);
		Material whiteDiffuseMat = new Material (Shader.Find ("Unlit/Texture"));
		lineRenderer.material = whiteDiffuseMat;
	}

	//Update is called once per framce
	void Update ()
	{
		//Rotate this object to face camera
		transform.rotation = Camera.main.transform.rotation;

		//draw line
		lineRenderer.SetPosition(0, origin.position);
		lineRenderer.SetPosition(1, destination.position);
	}
}