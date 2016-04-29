using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{

	public float rotationSpeed = 3;
	public float movementSpeed = 20;
	private Rigidbody player;

	void Start()
	{
		player = GetComponent<Rigidbody>();
		 
	}

	void Update()
	{
		if (Input.GetKey (KeyCode.LeftArrow))
		{
			transform.Rotate (new Vector3(0, -rotationSpeed, 0));
		}
		else if (Input.GetKey (KeyCode.RightArrow))
		{
				transform.Rotate (new Vector3(0, rotationSpeed, 0));
		}
		else if (Input.GetKey (KeyCode.UpArrow))
		{
			player.AddRelativeForce(0, 0, movementSpeed);
		}
	}
}