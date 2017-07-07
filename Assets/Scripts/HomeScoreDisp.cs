using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScoreDisp : MonoBehaviour {
	
	public GameObject coins;
	public GameObject highScoreUI;
		void Update () {
		coins.GetComponent<Text>().text = ("Coins Collected: "+DataMananger.dataMananger.coinsCollected.ToString());
		highScoreUI.GetComponent<Text>().text = ("High Score: "+DataMananger.dataMananger.highScore.ToString());
	}
}
