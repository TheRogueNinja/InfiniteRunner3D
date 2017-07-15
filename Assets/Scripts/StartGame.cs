using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartGame : MonoBehaviour {
	public static bool isPlaying;
	bool buttonStat = true;

	[SerializeField]
	public AudioSource audio;
	public void Starter()
	{
		SceneManager.LoadScene(1);
	}
	public void exit(){
		Debug.Log("Quit");
		Application.Quit();
	}
	public void audioKill()
	{
		if(audio.volume != 0f)
		{
			audio.volume = 0f;
			PlayerPrefs.SetInt("Vol", 0);
		}
		else
		{
			audio.volume = 1f;
			PlayerPrefs.SetInt("Vol", 1);
		}
		/*
		buttonStat = !buttonStat;
		if(buttonStat == true){
			GameObject.FindGameObjectWithTag("AudioSrc").SetActive(true);
		}
		else{
			GameObject.FindGameObjectWithTag("AudioSrc").SetActive(false);
		}
		*/
	}
}
