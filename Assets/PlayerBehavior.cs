using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {
	public float maxSpeed = 11f;
	public float range;
	float speed;
	float move;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		move = (speed * Input.GetAxis("Horizontal"));
		transform.Translate(Vector3.right * move);
		//float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		//float xPos = h * range;
		float yPos = v * range;



		//transform.position = new Vector3 (xPos, yPos, 0);
	}
}
