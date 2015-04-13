using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour {
	public float jetpackForce = 75.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// FixedUpdate is called at a fixed rate, should be used to write the code related to physics simulation
	void FixedUpdate(){
		bool jetpackActive = Input.GetButton ("Fire1");
		
		if (jetpackActive) {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jetpackForce));
		}
	}
}
