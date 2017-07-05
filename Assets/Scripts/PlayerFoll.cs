using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFoll : MonoBehaviour {

	public float camSpeed = 5f;
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 camPos = transform.position;
		camPos.x = player.transform.position.x- -4.0f;
		transform.position = Vector3.Lerp(transform.position, camPos, 3*Time.fixedDeltaTime);

		camPos.y = player.transform.position.y +2;
		transform.position = Vector3.Lerp(transform.position, camPos, 7f * Time.deltaTime);
	}
}
