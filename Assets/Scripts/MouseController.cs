using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour {
	public float jetpackForce = 75.0f;
	public float forwardMovementSpeed = 3.0f;

	public Transform groundCheckTransform;
	private bool grounded;
	public LayerMask groundCheckLayerMask;
	Animator animator;

	public ParticleSystem jetPack;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
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

		Vector2 newVelocity = GetComponent<Rigidbody2D> ().velocity;
		newVelocity.x = forwardMovementSpeed;
		GetComponent<Rigidbody2D> ().velocity = newVelocity;

		UpdateGroundedStatus();

		AjustJetPack(jetpackActive);
	}

	void UpdateGroundedStatus(){
		grounded = Physics2D.OverlapCircle(groundCheckTransform.position, 0.1f, groundCheckLayerMask);
		animator.SetBool("grounded", grounded);
	}

	void AjustJetPack(bool jetpackActive){
		jetPack.enableEmission = !grounded;
		jetPack.emissionRate = jetpackActive ? 300.0f : 75.0f;
	}
}
