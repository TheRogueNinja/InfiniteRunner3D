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
			GameObject Tree = Instantiate(trees[Random.Range(0, trees.Length)],new Vector3(gameObject.transform.position.x+70,0,Random.Range(-10,10)),Quaternion.Euler(0,Random.Range(0,360),0)) as GameObject;
			Tree.transform.localScale = new Vector3(Random.Range(1f,2.5f),Random.Range(1f,2.5f),Random.Range(1f,2.5f));
			treeTimer=0.3f;
		}
	}
}
