using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMan : MonoBehaviour {
	public GameObject scoreUI;
	public GameObject highScoreUI;
		void Update () {
		if(DataMananger.dataMananger.currentScore > DataMananger.dataMananger.highScore){
			DataMananger.dataMananger.highScore = DataMananger.dataMananger.currentScore;
		}

		scoreUI.GetComponent<Text>().text = ("Score: "+DataMananger.dataMananger.currentScore.ToString());
		highScoreUI.GetComponent<Text>().text = ("High Score: "+DataMananger.dataMananger.highScore.ToString());
	}
}
