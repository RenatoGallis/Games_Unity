using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Inicia o game
		if (Input.GetKey(KeyCode.Return) || Input.touchCount == 2) {
			PrincipalScript.vidas = 5;
			PrincipalScript.pontos = 0;
			SceneManager.LoadScene ("Game");
		}	
	}
}
