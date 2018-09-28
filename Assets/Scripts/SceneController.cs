using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {
	[SerializeField] private GameObject enemyPrefab;
	private GameObject[] _enemy;
	public int count;
	public int count1;
	public int i;

	void Start(){
		count = Random.Range (1,4);
		count1 = count;
		_enemy = new GameObject[20];
		for (i=0; i < count1; i++) {

			_enemy[i] = Instantiate(enemyPrefab) as GameObject;
			_enemy[i].transform.position = new Vector3(0, 1, 0);
			float angle = Random.Range(0, 360);
			_enemy[i].transform.Rotate(0, angle, 0);

		}

	}


}
