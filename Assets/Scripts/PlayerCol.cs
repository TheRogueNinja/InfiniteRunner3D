using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCol : MonoBehaviour {
	public AudioClip enemyHit,coinCollect,restart;
	public GameObject RestartUI;
	public GameObject HomeUI;
	public GameObject crashParticle;
	public GameObject Fireworks;
	PlayerFoll pf;
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Enemy"){
			DataMananger.dataMananger.saveData();
			//Destroy(jetPack);
			GetComponent<AudioSource>().PlayOneShot(enemyHit,1.0f);
			GetComponent<Rigidbody>().isKinematic = true;
			GetComponent<PlayerMov>().enabled = false;
			GetComponent<PlayerMov>().jetFlame.SetActive(false);
			//GetComponent<MeshRenderer>().enabled = false;
			crashParticle.SetActive(true);
			StartGame.isPlaying=false;
			Invoke("HitEnemyMenu",2.5f);
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
	void HitEnemyMenu(){
		GetComponent<AudioSource>().PlayOneShot(restart,1.0f);
		//SceneManager.LoadScene("Main");
		RestartUI.SetActive(true);
		HomeUI.SetActive(true);
		if(DataMananger.dataMananger.currentScore > DataMananger.dataMananger.highScore){
				Debug.Log("Here");
				Vector3 fireWorkPos = transform.position;
				fireWorkPos = new Vector3(pf.player.transform.position.x,0,pf.player.transform.position.z+50);
				Fireworks.SetActive(true);
			}
		

	}
	
}
