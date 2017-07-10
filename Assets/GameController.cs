using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public int player1Score;
	public int player2Score;

	// Use this for initialization
	void Start () {
		player1Score = 0;
		player2Score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void addScore (int whichPlayer){
		Debug.Log ("we made it");
		if (whichPlayer == 1) {
			player1Score++;
		} else if (whichPlayer == 2) {
			player2Score++;
		}
	}
}
