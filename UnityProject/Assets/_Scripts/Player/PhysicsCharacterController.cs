using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsCharacterController : MonoBehaviour {

	public bool IsGrounded { get; private set; }
	[SerializeField]
	private CircleCollider2D feetCollider;
	[SerializeField]
	private LayerMask layerMask;


	void FixedUpdate()
	{
		if(feetCollider == null)
			return;

		if(Physics2D.OverlapCircle(this.feetCollider.transform.position, this.feetCollider.radius, layerMask))
		{
			IsGrounded = true;
		}
		else
		{
			IsGrounded = false;
		}
	}
}
