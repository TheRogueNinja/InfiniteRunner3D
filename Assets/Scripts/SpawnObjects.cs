using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

	public GameObject player;
	public GameObject enemy;	
	public GameObject[] coins;
	public GameObject[] trees;
	float coinTimer = 7f;
	float enemyTimer = 10f;
	float treeTimer = 0.5f;
	
	public bool isPlaying;
	// Update is called once per frame
	void Start () {
		isPlaying = true;
		DataMananger.dataMananger.currentScore=0;
		DataMananger.dataMananger.loadData();
		Debug.Log("Load");
	}
	void Update () {
		coinTimer-=Time.deltaTime;
		enemyTimer-=Time.deltaTime;
		treeTimer-=Time.deltaTime;
		if(coinTimer<=0.01 && isPlaying == true){
			spawnCoins();
		}
		if(enemyTimer<=0.01 && isPlaying == true){
			spawnEnemy();
		}
		if(treeTimer<=0.01 && isPlaying == true){
			spawnTrees();
		}

	}
	void spawnCoins(){
		Instantiate(coins[(Random.Range(0,coins.Length))], new Vector3(player.transform.position.x+30,Random.Range(2,8),-25), Quaternion.identity);
		coinTimer = Random.Range(1f,3f);
	}
	void spawnEnemy(){
		enemy.transform.localScale = new Vector3(Random.Range(1,5),Random.Range(1,5),Random.Range(1,5));
		Instantiate(enemy,new Vector3(player.transform.position.x+30,Random.Range(1,9),-25),Quaternion.identity);
		enemyTimer = Random.Range(1f,4f);
	}
	void spawnTrees(){
		Instantiate(trees[Random.Range(0,trees.Length)],new Vector3(player.transform.position.x+70,0,Random.Range(-10,10)),Quaternion.identity);
		treeTimer = 0.5f;
	}
}
