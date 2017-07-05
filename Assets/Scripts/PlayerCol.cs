using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCol : MonoBehaviour {
	public AudioClip enemyHit,coinCollect,restart;
	public GameObject RestartUI;
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Enemy"){
			DataMananger.dataMananger.saveData();
			GetComponent<AudioSource>().PlayOneShot(enemyHit,1.0f);
			GetComponent<Rigidbody>().isKinematic = true;
			GetComponent<PlayerMov>().enabled = false;
			Invoke("Restart",2f);
		}
	}
	void OnTriggerEnter(Collider trig){
		if(trig.tag == "Coin"){
			GetComponent<AudioSource>().PlayOneShot(coinCollect,1.0f);
			Destroy(trig.gameObject);
			DataMananger.dataMananger.coinsCollected++;
			DataMananger.dataMananger.currentScore++;
		}
	}
	void Restart(){
		GetComponent<AudioSource>().PlayOneShot(restart,1.0f);
		SceneManager.LoadScene("Main");
	}
	
}
