using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBirdScript : MonoBehaviour {


	public static bool inGame; //static fica acessivel em todas as classes
	public float impulso; //quando public aparece no painel do unity


	//Componentes que tenho que acessar
	Rigidbody2D rb;


	//Configurãcoes iniciais do jogo
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

		//Desabilita a gravidade enquanto o jogo não tem inicio
		rb.gravityScale = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		//Habilita gravidade quando o cara começa a jogar
		if (!inGame && Input.GetButtonDown ("Fire1")) {
			inGame = true;
			rb.gravityScale = 1.0f;
		} else if (inGame && Input.GetButtonDown ("Fire1")) {
			rb.velocity = new Vector2 (0.0f, impulso);
		}
	}

	//Esse metodo eh chamado automaticamente quando o objeto para pelo trigger
	//Detecta colisao com trigger
	void OnTriggerEnter2D(Collider2D c) {
		PrincipalScript.pontos++;
		print(PrincipalScript.pontos);
	}

	//Se colidir com algo volta para o início
	void OnCollisionEnter2D(Collision2D c) {
		SceneManager.LoadScene("start");
	}

}
