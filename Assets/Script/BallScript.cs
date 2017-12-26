using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour {
	
	public float ballForce;

	void Start () {
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (ballForce, ballForce));
		print (ballForce);
	}
		
	void Update(){
		print (ballForce);
	}

	void OnCollisionEnter2D(Collision2D c) {
		if (c.gameObject.tag == "Bloco") {
			PrincipalScript.pontos++;
			Destroy (c.gameObject);
			if (PrincipalScript.pontos == 9) {
				SceneManager.LoadScene ("Start");
			}
		}
		if (c.gameObject.tag == "Chao") {
			PrincipalScript.vidas--;
			if (PrincipalScript.vidas <= 0) {
				SceneManager.LoadScene ("Start");				
			} else {
				GetComponent<Rigidbody2D> ().position = new Vector2 (0.0f, 0.0f);
//				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (ballForce, ballForce));
			}
		}
	}


	//NAO FUNCIONOU
//	public float speed = 100.0f;
//
//	void Start () {
//		GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
//	}
//
//	void OnCollisionEnter2D(Collision2D col) {
//		// Hit the Racket?
//		if (col.gameObject.name == "Bloco") {
//			// Calculate hit Factor
//			float x=hitFactor(transform.position,
//				col.transform.position,
//				col.collider.bounds.size.x);
//
//			// Calculate direction, set length to 1
//			Vector2 dir = new Vector2(x, 1).normalized;
//
//			// Set Velocity with dir * speed
//			GetComponent<Rigidbody2D>().velocity = dir * speed;
//		}
//	}
//
//	float hitFactor(Vector2 ballPos, Vector2 racketPos,
//		float racketWidth) {
//		// ascii art:
//		//
//		// 1  -0.5  0  0.5   1  <- x value
//		// ===================  <- racket
//		//
//		return (ballPos.x - racketPos.x) / racketWidth;
//	}


}
