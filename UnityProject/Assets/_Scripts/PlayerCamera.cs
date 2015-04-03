using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour 
{
	private Transform target;

	public static PlayerCamera instance;
	[SerializeField]
	private Vector2 offset;
	[SerializeField]
	private float distance = 5;
	void Awake()
	{
		//Destroy self if an instance of PlayerCamera exists
		if(instance != null)
		{
			GameObject.Destroy(gameObject);
			return;
		}

		instance = this;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(target == null)
			return;

		Vector3 position = target.position;
		position.x += offset.x;
		position.y += offset.y;
		position.z = -distance;
		this.transform.position = Vector3.Lerp (this.transform.position, position, 10 * Time.deltaTime);
	}

	public void SetTarget(Transform target)
	{
		this.target = target;
	}
}
