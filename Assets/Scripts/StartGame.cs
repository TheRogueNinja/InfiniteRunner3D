using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartGame : MonoBehaviour {
	public static bool isPlaying;
	bool buttonStat = true;
	public void Starter(){
		SceneManager.LoadScene(1);
	}
	public void exit(){
		Debug.Log("Quit");
		Application.Quit();
	}
	public void audioKill(){
		buttonStat = !buttonStat;
		if(buttonStat == true){
			GameObject.FindGameObjectWithTag("AudioSrc").SetActive(true);
		}
		else{
			GameObject.FindGameObjectWithTag("AudioSrc").SetActive(false);
		}
	}
}
