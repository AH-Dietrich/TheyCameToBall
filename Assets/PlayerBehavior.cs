using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerBehavior : MonoBehaviour {

    public float speed;
	public Vector3 jumpSpeed;
	private Vector3 moveDirection = Vector3.zero;
	public bool isTouchingGround;

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Ground") {
			isTouchingGround = true;
		}
	}

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        //float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal * Time.deltaTime * speed, 0.0f, 0.0f);

        //rb.AddForce (movement * speed);
		rb.transform.Translate (movement, Space.World);

		if (Input.GetButton ("Jump") && isTouchingGround) {
			isTouchingGround = false;
			Debug.Log ("to ere");
			//moveDirection.y = jumpSpeed;
			//rb = GetComponent<Rigidbody>();
			//jumpSpeed = new Vector3 (0.0f, 2.0f, 0.0f);
			rb.AddForce (new Vector3 (0, 20, 0), ForceMode.Impulse);

		}

    }
}