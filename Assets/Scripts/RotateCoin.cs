using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour {

	// Use this for initialization
	public float rotateSpeed = 500;
	// Update is called once per frame
	void Update () {

			transform.Rotate(Vector3.up*rotateSpeed*Time.deltaTime);
	}
}
