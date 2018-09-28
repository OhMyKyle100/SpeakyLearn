using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Title : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void Return(){

		SceneManager.LoadScene ("TitleScreen");

	}
}