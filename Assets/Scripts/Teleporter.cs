using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="Player")
		{
			
			other.gameObject.transform.position = new Vector3(9.06f, -0.15f, -13f);
		}
	}
}
