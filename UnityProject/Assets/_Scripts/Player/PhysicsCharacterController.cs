using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsCharacterController : MonoBehaviour {

	public bool IsGrounded { get; private set; }


}
