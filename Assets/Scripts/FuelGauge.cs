using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelGauge : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
		if(PlayerMov.jetPackFuel > 0.01)
		{
			gameObject.transform.localScale = new Vector3(PlayerMov.jetPackFuel,1,1);
		}
	}
}
