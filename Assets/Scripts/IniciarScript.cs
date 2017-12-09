using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class IniciarScript : MonoBehaviour {

	//public Text txtPontos;

	// Use this for initialization
	void Start () {
		FlappyBirdScript.inGame = false;
	}
	
	// Update is called once per frame
	void Update () {

		print (Input.touchCount);

		//Exibe pontuacao
		//txtPontos.text = PrincipalScript.pontos.ToString();

		//enter ou clicar com 2 dedos na tela
		if(Input.GetKeyDown (KeyCode.Return) || Input.touchCount == 2) {
			PrincipalScript.pontos = 0;
			SceneManager.LoadScene("jogo");
		}
	}
}
