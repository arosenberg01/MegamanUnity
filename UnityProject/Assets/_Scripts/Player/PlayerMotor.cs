using UnityEngine;
using System.Collections;

public class PlayerMotor : MonoBehaviour 
{
	public float Speed { 
		get {
			return speed;
		}
	}

	public float CurrentSpeed {
		get {
			return this.rigidbody.velocity.magnitude;
		}
	}

	[SerializeField]
	private float speed = 5;
	[SerializeField]
	private float jumpHeight = 10f;
	[SerializeField]
	private float gravity = -9.81f;

	private Rigidbody2D rigidbody = null;
	private Vector2 currentVelocity;
	private PhysicsCharacterController characterController;

	void Awake() {
		this.rigidbody = GetComponent<Rigidbody2D>();
		this.characterController = GetComponent<PhysicsCharacterController>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Move(float x, float y)
	{
		if(this.characterController.IsGrounded)
		{
			currentVelocity.y = 0;
		}
		ApplyGravity();
		currentVelocity = new Vector2(x * speed, currentVelocity.y);
		this.rigidbody.velocity = currentVelocity;
	}

	private void ApplyGravity()
	{
		currentVelocity.y += gravity * Time.deltaTime;
	}
}
