using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioKill : MonoBehaviour {
	bool soundToggle = true;

	[SerializeField]
	public AudioSource audio;

	public void audioKill()
	{

		if(audio.volume != 0f)
		{
			audio.volume = 0f;
		}
		else
		{
			audio.volume = 1f;
		}
		/**
		soundToggle = !soundToggle;
		Debug.Log(soundToggle);
		if(soundToggle)
  			{
   				
				GetComponent<AudioSource>().Equals(true);
   				//audioSource.mute = true;
   				//audioSource.volume = 1.0f;
  			}
		
		GetComponent<AudioSource>().Equals(false);
		**/
	}
}
