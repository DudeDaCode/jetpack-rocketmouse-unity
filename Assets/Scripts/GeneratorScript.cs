using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GeneratorScript : MonoBehaviour {
	public GameObject[] availableRooms;
	public List<GameObject> currentRooms;
	public float screenWidthInPoints;

	// Use this for initialization
	void Start () {
		float height = 2.0f * Camera.main.orthographicSize;
		screenWidthInPoints = height * Camera.main.aspect;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void AddRoom(float farhtestRoomEndX){
		int randomRoomIndex = Random.Range(0, availableRooms.Length);

		GameObject room = (GameObject)Instantiate(availableRooms[randomRoomIndex]);

		float roomWidth = room.transform.FindChild("Floor").localScale.x;

		float roomCenter = farhtestRoomEndX + roomWidth * 0.5f;

		room.transform.position = new Vector3(roomCenter, 0, 0);

		currentRooms.Add(room);
	}
}
