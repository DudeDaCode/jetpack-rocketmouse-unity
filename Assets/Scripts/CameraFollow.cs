using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public GameObject targetObject;
	private float distanceTarget;

	// Use this for initialization
	void Start () {
		distanceTarget = transform.position.x - targetObject.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		float targetObjectX = targetObject.transform.position.x;

		Vector3 newCameraPosition = transform.position;
		newCameraPosition.x = targetObjectX + distanceTarget;
		transform.position = newCameraPosition;
	}
}
