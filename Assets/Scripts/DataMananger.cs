using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class DataMananger : MonoBehaviour {
	public static DataMananger dataMananger;
	public int highScore;
	public int coinsCollected;
	public int currentScore;
	void Awake(){
		if(dataMananger == null){
			DontDestroyOnLoad(gameObject);
			dataMananger = this;
		}
		else if(dataMananger != null){
			Destroy(gameObject);
		}
	}
	public void saveData(){
		Debug.Log("Save");
		BinaryFormatter binForm = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/gameInfo.dat");
		gameData data = new gameData();
		data.highScore = highScore;
		data.coinsCollected = coinsCollected;
		binForm.Serialize(file,data);
		file.Close();
	}
	public void loadData(){
		if(File.Exists(Application.persistentDataPath + "/gameInfo.dat")){
			BinaryFormatter binForm = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/gameInfo.dat",FileMode.Open);
			gameData data = (gameData)binForm.Deserialize(file);
			file.Close();
			highScore = data.highScore;
			coinsCollected = data.coinsCollected;
			Debug.Log("load");
		}
	}

}

[System.Serializable]

public class gameData {
	public int highScore;
	public int coinsCollected;
}