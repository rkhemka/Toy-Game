using UnityEngine;
using System.Collections;

public class ReactiveTarget : MonoBehaviour {
	public GameObject MyPlayer;

	public void ReactToHit() {
		WanderingAI behavior = GetComponent<WanderingAI>();
		if (behavior != null) {
			behavior.SetAlive(false);
		}
		StartCoroutine(Die());
	}

	private IEnumerator Die() {
		this.transform.Rotate(-90, 0, 0);

		yield return new WaitForSeconds(1.0f);
		MyPlayer.GetComponent<Animation> ().CrossFade ("Take 001", 1.0f);

		Destroy(this.gameObject);

	}
}