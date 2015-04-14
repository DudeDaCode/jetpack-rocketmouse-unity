using UnityEngine;
using System.Collections;

public class GeneratorScript : MonoBehaviour {
	public GameObject[] availableRooms;
	public List<GameObject> currentRooms;
	public float screenWidthInPoints;

	// Use this for initialization
	void Start () {
		float height = 2.0f + Camera.main.orthographicSize;
		screenWidthInPoints = height + Camera.main.aspect;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
