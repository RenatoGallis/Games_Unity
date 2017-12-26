using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour {
	public float velocidade;
	public float limiteEsquerdo, limiteDireito;

	void Start () {
		
	}

	void Update () {
		Mover ();		
	}

	void Mover(){
	
		// Mover 
		float move_x = Input.GetAxisRaw ("Horizontal"); //* velocidade * Time.deltaTime;
		GetComponent<Rigidbody2D>().velocity = Vector2.right * move_x * velocidade;
//		transform.Translate (move_x, 0.0f, 0.0f);

		//Wrap
//		if (transform.position.x < limiteEsquerdo || transform.position.x > limiteDireito) {
//			transform.position = new Vector2 (transform.position.x * -1, transform.position.y);
//		}
	
		if (transform.position.x < limiteEsquerdo || transform.position.x > limiteDireito) {
			transform.position = new Vector2 (transform.position.x, transform.position.y);
		}

	}
}
