using UnityEngine;

public class SpawnTrees : MonoBehaviour {

	public GameObject[] trees;
	float treeTimer = 0.3f;
	// Update is called once per frame
	float treeBeforeTime = 20;

	Vector3 treeBeforeSpawnLoc;
	void Update () {
		StartGame.isPlaying = true;
		gameObject.transform.Translate(transform.right*10*Time.deltaTime);
		treeTimer-=Time.deltaTime;
		if(treeTimer<=0.01){
			Instantiate(trees[Random.Range(0, trees.Length)],new Vector3(gameObject.transform.position.x+70,0,Random.Range(-10,10)),Quaternion.identity);
			treeTimer=0.3f;
		}
	}
}
