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
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		motor.Move(horizontal, 0);
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
