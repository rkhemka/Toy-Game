using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	[SerializeField] private GameObject enemyPrefab;
	public GameObject[] enemies;
	public int amount;
	private Vector3 spawnPoint;
	public int count11;
	public int i;
	
	// Update is called once per frame
	void Update () {
		enemies = new GameObject[10];
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		amount = enemies.Length;

		if(amount < 8){
			InvokeRepeating ("spawnEnemy", 30, 25f);	
		}
		if (amount > 9) {
			Destroy (enemyPrefab.gameObject);
		}

	}

	void spawnEnemy(){
		spawnPoint.x = Random.Range (-10, 15);
		spawnPoint.y = 0.2f;
		spawnPoint.z = Random.Range (-10, 15);
		count11 = Random.Range (1,2);
		for(i=0; i<=count11; i++){
			enemies[i] = Instantiate(enemyPrefab) as GameObject;
			enemies[i].transform.position = new Vector3(0, 1, 0);
			float angle = Random.Range(0, 360);
			enemies[i].transform.Rotate(0, angle, 0);

			
		}

		//Instantiate (enemyPrefab [UnityEngine.Random.Range (0, amount+2)], spawnPoint, Quaternion.identity) as GameObject;
		CancelInvoke ();
	
	}
}
