using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour {

	public float speed =10f;
	public static float jetPackFuel = 1.5f;
	public float jetPackForce =70f;
	public AudioClip jetPack;
	public GameObject jetFlame;
	// Update is called once per frame
	void FixedUpdate () {
		gameObject.transform.Translate(transform.right*speed*Time.fixedDeltaTime);
	}
	void Update(){
		if(Input.GetButton("Fire1") && jetPackFuel>=0.01f)
        {
			GetComponent<AudioSource>().PlayOneShot(jetPack, 0.2f);
            jetPackFuel = Mathf.MoveTowards(jetPackFuel, 0, Time.deltaTime);
			jetFlame.SetActive(true);
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jetPackForce));
        }
		else
		{
			jetFlame.SetActive(false);
		}
    }
    void OnCollisionEnter(Collision col){
			if(col.gameObject.tag == "Ground"){
				jetPackFuel = 1.5f;
			}
		}
}
