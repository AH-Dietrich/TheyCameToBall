using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour {
	public GameController gameController;

	// Use this for initialization
	void Start () {
		//Check for score, if 0,0 then spawn in middle, else spawn to loser
		//give gravity stuff
		//give initial velocity (0)
	}
	
	// Update is called once per frame
	void Update () {
		//check collision with rigid body (wall, players, net)
		//check for ground collision (score for other side)

	}
	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.transform.name == "Ground1"){
			Debug.Log ("to ere");
			gameController.addScore(1);
		} 
		else if(collision.gameObject.transform.name == "Ground2"){
			gameController.addScore(2);
		}
	}
}
