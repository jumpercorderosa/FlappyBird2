using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

	//recebe o elemento texto UI para atualizar o placar
	public Text txtPontos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		txtPontos.text = PrincipalScript.pontos.ToString();
	}
}
