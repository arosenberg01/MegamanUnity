using UnityEngine;
using System.Collections;

public class PlayerAnimatorController : MonoBehaviour {
	private PlayerMotor motor;
	private PhysicsCharacterController controller;
	private float speed = 10;
	private Animator animator;

	void Awake()
	{
		motor = GetComponent<PlayerMotor>();
		animator = GetComponent<Animator>();
		controller = GetComponent<PhysicsCharacterController>();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		if(motor == null && controller == null)
			return;
		animator.SetBool("isGrounded", controller.IsGrounded);
		animator.SetFloat("Speed", Mathf.Abs(motor.CurrentVelocity.x)/motor.Speed);
	}
}
