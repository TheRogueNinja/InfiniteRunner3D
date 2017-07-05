using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour {

	public float speed =10f;
	public static float jetPackFuel = 1.5f;
	public float jetPackForce =70f;
	public AudioClip jetPack;
	public ParticleSystem jetFlame;
	// Update is called once per frame
	void start(){
        //ParticleSystem.EmissionModule jetFlame; 
	}
	void FixedUpdate () {
		gameObject.transform.Translate(transform.right*speed*Time.fixedDeltaTime);
	}
	void Update(){
		if(Input.GetButton("Jump") && jetPackFuel>=0.01f)
        {
            GetComponent<AudioSource>().PlayOneShot(jetPack, 0.2f);
            jetPackFuel = Mathf.MoveTowards(jetPackFuel, 0, Time.deltaTime);
            flameOn();
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jetPackForce));
        }
    }
	bool flameOn(){
		return jetFlame.GetComponent<ParticleSystem>().emission.enabled;
	}

    void OnCollisionEnter(Collision col){
			if(col.gameObject.tag == "Ground"){
				jetPackFuel = 1.5f;
			}
		}
}
