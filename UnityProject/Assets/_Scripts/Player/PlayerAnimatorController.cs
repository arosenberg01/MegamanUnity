using UnityEngine;
using System.Collections;

public class PlayerAnimatorController : MonoBehaviour {
	private PlayerMotor motor;
	private float speed = 10;
	private Animator animator;

	void Awake()
	{
		motor = GetComponent<PlayerMotor>();
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		if(motor == null)
			return;

		animator.SetFloat("Speed", Mathf.Abs(motor.CurrentVelocity.x)/motor.Speed);
	}
}
