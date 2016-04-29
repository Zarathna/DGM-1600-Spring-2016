using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public float time = 5.0f;

	void Update()
	{
		time -= Time.deltaTime;
		if(time < 0.0f)
		{
			Destroy(gameObject);
		}
	}
}