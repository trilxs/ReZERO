using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float cam_speed = 0.1f;
	Camera camera;

	// Use this for initialization
	void Start () {

		camera = GetComponent<Camera>();

	}
	
	// Update is called once per frame
	void Update () {
		camera.orthographicSize = (Screen.height / 100f) / 4f; //4f is arbituary. crossplatform

		if (target) {
			transform.position = Vector3.Lerp(transform.position, target.position, cam_speed) + new Vector3(0, 0, -10);
		}
	}
}
