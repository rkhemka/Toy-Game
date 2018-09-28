using UnityEngine;
using System.Collections;

public class WanderingAI : MonoBehaviour 
{
	public GameObject MyPlayer;
	public float speed = 2.0f;
	public float obstacleRange = 5.0f;

	[SerializeField] private GameObject fireballPrefab;
	private GameObject _fireball;
	private GameObject player;
	public float playerDistance;


	private bool _alive;

	void Start() {
		_alive = true;
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update() {
		if (_alive) {
			transform.Translate(0, 0, speed * Time.deltaTime);
			playerDistance = Vector3.Distance (transform.position, player.transform.position);

			Ray ray = new Ray(transform.position, transform.forward);
			RaycastHit hit;
			if (Physics.SphereCast(ray, 0.75f, out hit)) 
			{
				if (playerDistance < 10f)
				{
					speed = 0f;
					MyPlayer.GetComponent<Animation> ().CrossFade ("shoot", 1.0f);
					transform.LookAt (player.transform);
				}
				else 
				{
					speed = 2.0f;
					MyPlayer.GetComponent<Animation> ().CrossFade ("walk", 1.0f);
				}
				GameObject hitObject = hit.transform.gameObject;
				if (hitObject.GetComponent<PlayerCharacter>()) {
					if (_fireball == null) {
						_fireball = Instantiate(fireballPrefab) as GameObject;
						_fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
						_fireball.transform.rotation = transform.rotation;
					}
				}
				else if (hit.distance < obstacleRange) {
					if (playerDistance < 10f) {
						speed = 0f;
						MyPlayer.GetComponent<Animation> ().CrossFade ("shoot", 1.0f);
						//yield return new WaitForSeconds(0.4f);
						//MyPlayer.GetComponent<Animation> ().CrossFade ("run", 1.0f);
						transform.LookAt (player.transform);
					} else {
						speed = 2.0f;
						float angle = Random.Range(-110, 110);
						transform.Rotate(0, angle, 0);
					}

				}
			}
		}
	}

	public void SetAlive(bool alive) {
		_alive = alive;
	}
}
