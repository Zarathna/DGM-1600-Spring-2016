using UnityEngine;
using System.Collections;

public class IfStatements1 : MonoBehaviour
{

	bool isFlying = false;

	void Start ()
	{
		if (isFlying == false)
		{
			Debug.Log ("isFlying is now " + isFlying);
			isFlying = FlyingTest ();
			Debug.Log ("isFlying is now " + isFlying);
		}
		else if (isFlying == true)
		{
			Debug.Log ("isFlying is already true");
		}

	}

	bool FlyingTest()
	{
		return true;
	}
}
