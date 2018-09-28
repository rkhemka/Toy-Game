using UnityEngine;
using System.Collections;

public class GunSwitching : MonoBehaviour {
	public GameObject[] weapons = new GameObject[2];
	public GameObject currentWeapon;
	public int index=0;
	// Use this for initialization
	void Start () {
		selectWeapon (index);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) {
			index++;
			if (index > weapons.Length) {
				index = 0;
			}
			selectWeapon (index);
		}	
	}

	void selectWeapon(int index)
	{
		for (int i = -0; i < weapons.Length; i++) {
			if (i == index) {
				transform.GetChild (i).gameObject.SetActive (true);
			} else {
				transform.GetChild (i).gameObject.SetActive (false);
			}
		}
	}
}
