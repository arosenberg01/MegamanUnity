using UnityEngine;
using System.Collections;

public class PlayerMotor : MonoBehaviour 
{
	//accessor
	//setter
	public Vector2 CurrentVelocity
	{
		get
		{
			return this.rigidbody.velocity;
		}
	}

	public float Speed
	{
		get
		{
			return speed;
		}
	}
	[SerializeField]
	private float jumpForce = 5;
	[SerializeField]
	private float speed = 10;
	[SerializeField]
	private float gravity = -9.81f;

	private PhysicsCharacterController characterController;
	private Rigidbody2D rigidbody;

	void Awake() {
		this.characterController = GetComponent<PhysicsCharacterController>();
		this.rigidbody = GetComponent<Rigidbody2D>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Move(float x, bool jump)
	{
		float y = this.rigidbody.velocity.y;
		if(characterController.IsGrounded)
		{
			y = 0;
			if(jump)
			{
				y = this.jumpForce;
			}
		}
		y += gravity * Time.deltaTime;

		this.rigidbody.velocity = new Vector2(x * speed, y);
	}

}
