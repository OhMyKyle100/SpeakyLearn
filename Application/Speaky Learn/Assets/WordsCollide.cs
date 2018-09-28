using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordsCollide : MonoBehaviour {

	public GameObject CameraToShake;
	public float shakeTimer;
	public float shakeAmount;
	public AudioClip soundToPlay;




	// Use this for initialization
	void Start () {

	

	}

	// Update is called once per frame


	void Update () {


		if (shakeTimer >= 0) {

			Vector2 ShakePos = Random.insideUnitCircle * shakeAmount;

			CameraToShake.transform.position = new Vector3 (CameraToShake.transform.position.x + ShakePos.x, CameraToShake.transform.position.y + ShakePos.y, CameraToShake.transform.position.z);

			shakeTimer -= Time.deltaTime;
		}

		else{
			
			CameraToShake.transform.position = new Vector3 (0f,0f, CameraToShake.transform.position.z);﻿
		}
		
	}

	public void ShakeCamera(float shakePwr, float shakeDur){

		shakeAmount = shakePwr;
		shakeTimer = shakeDur;

	}


	void OnTriggerEnter(Collider other) {
		
		this.GetComponent<AudioSource> ().PlayOneShot (soundToPlay);
		Debug.Log ("i ontriggered with an " + other.gameObject.name);
		ShakeCamera(0.1f, 1);

		if (other.tag == "Last"){
			SceneManager.LoadScene ("GameOverScreen");

		}
	}
}