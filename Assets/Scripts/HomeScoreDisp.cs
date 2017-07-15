using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScoreDisp : MonoBehaviour {
	
	public GameObject coins;
	public GameObject highScoreUI;

public GameObject dataMan;

	void Start()
	{
		dataMan.GetComponent<DataMananger>().loadData();
		coins.GetComponent<Text>().text = ("Coins Collected: "+dataMan.GetComponent<DataMananger>().coinsCollected.ToString());
		highScoreUI.GetComponent<Text>().text = ("High Score: "+dataMan.GetComponent<DataMananger>().highScore.ToString());
	}
}
