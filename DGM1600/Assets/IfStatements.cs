using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

	public float coffeeTemperature = 85.0f;
	public float hotLimitTemperature = 70.0f;
	public float coldLimitTemperature = 40.0f;


	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();

		coffeeTemperature -= Time.deltaTime * 5f;
	}


	void TemperatureTest()
	{
		if(coffeeTemperature > hotLimitTemperature)
		{
			Debug.Log("Coffee is too hot.");
		}
		else if(coffeeTemperature < coldLimitTemperature)
		{
			Debug.Log("Coffee is too cold.");
		}
		else
		{
			Debug.Log("Coffee is just right.");
		}
	}
}