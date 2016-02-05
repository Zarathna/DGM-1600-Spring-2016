using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour {

	int myInt = 5;
	void Start () {

		 MultiplyByFour (myInt);
		Debug.Log (myInt);

	}

	int MultiplyByFour(int number){
		int ret;

		ret = number * 4;

		return 10;
	}


}
