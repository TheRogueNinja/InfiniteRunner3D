using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
	float timeToDestroy = 15.0f;
	// Update is called once per frame
	void Update () {
		timeToDestroy -= Time.deltaTime;
		if(timeToDestroy < 0.01 && StartGame.isPlaying == true){
			Destroy(gameObject);
		}
	}
}
