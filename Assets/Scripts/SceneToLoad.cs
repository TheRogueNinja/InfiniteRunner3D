using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneToLoad : MonoBehaviour {
	public void SceneChangeHome(){
		SceneManager.LoadScene(sceneBuildIndex:0);
	}
	public void SceneChangeRestart(){
		SceneManager.LoadScene(sceneBuildIndex:1);
	}
	
}
