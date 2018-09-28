using UnityEngine;
using System.Collections;

public class Teleporter1 : MonoBehaviour {

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
			
			other.gameObject.transform.position = new Vector3(20.0f, 0.02f, -29.2f);
		}
	}
}