using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D rigid;

	private Vector3 moveInput;
	private Vector3 moveVelocity;



	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		moveInput = new Vector3 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
		moveVelocity = moveInput * moveSpeed;

		//rotate with controller
		Vector3 playerDirection =  Vector3.forward * Input.GetAxisRaw("rHorizontal") * 5  + Vector3.forward * -Input.GetAxisRaw("rVertical") * 5;
		if (playerDirection.sqrMagnitude > 0.0f) {
			transform.Rotate(playerDirection);
			//Debug.Log (playerDirection);
		}
	}
	

	void FixedUpdate()
	{
		rigid.velocity = moveVelocity; 
	}
}
