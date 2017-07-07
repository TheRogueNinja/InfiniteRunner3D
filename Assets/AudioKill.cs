using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioKill : MonoBehaviour {
	bool soundToggle = true;
	public void audioKill(){
		soundToggle = !soundToggle;
		Debug.Log(soundToggle);
		if(soundToggle)
  			{
   				
				GetComponent<AudioSource>().Equals(true);
   				//audioSource.mute = true;
   				//audioSource.volume = 1.0f;
  			}
		
		GetComponent<AudioSource>().Equals(false);
	}
}
