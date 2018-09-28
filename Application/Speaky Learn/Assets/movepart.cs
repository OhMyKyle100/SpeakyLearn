using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepart : MonoBehaviour {

	public float movementSpeed = 10;

	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.down * movementSpeed * Time.deltaTime);

	}
}

