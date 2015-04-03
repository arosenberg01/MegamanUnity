using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	private PlayerMotor motor;
	private bool isFlipped = false;

	void Awake() {
		motor = GetComponent<PlayerMotor>();
	}

	// Use this for initialization
	void Start () {
		PlayerCamera.instance.SetTarget(this.transform);
	}
	
	// Update is called once per frame
	void Update () 
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		if(horizontal > 0)
			horizontal = 1;
		else if(horizontal < 0)
			horizontal = -1;

		motor.Move(horizontal, Input.GetButton("Jump"));
		if(horizontal < 0 && !isFlipped)
		{
			Flip ();
		}
		else if(horizontal > 0 && isFlipped)
		{
			Flip ();
		}
	}

	void Flip()
	{
		isFlipped = !isFlipped;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
	}
}
