using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	PlayerController controller;
	Rigidbody2D rigidbody2D;
	Pet pet;

	public float speed;
	public int dir;
	public LayerMask outerWalls;
	/*public Vector2 mousePos;
	public Vector2 centerToMouse;
	public Vector2 originalRotation;
	public float newRotation;*/

	// Use this for initialization
	void Start () {
		controller = GetComponent<PlayerController> ();
		rigidbody2D = GetComponent<Rigidbody2D> ();
		pet = GetComponent<Pet> ();
		speed = 5;
		dir = 0;
		/*mousePos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
		originalRotation = new Vector2(0, 1);*/
	}
	
	// Update is called once per frame
	void Update () {

		/*//AIM AND ROTATION
		mousePos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
		Vector2 screenCenter = new Vector2 (Screen.width / 2, Screen.height / 2);
		centerToMouse = new Vector2 (mousePos.x - screenCenter.x, mousePos.y - screenCenter.y);
		newRotation = Vector2.Angle (originalRotation, centerToMouse);
		Quaternion curRot = transform.rotation;
		Quaternion newRot = new Quaternion (curRot.x, curRot.y, newRotation, 0);
		transform.rotation = newRot;*/


		if(Input.GetKeyDown(KeyCode.E)) {
			pet.UsePet();
		}
		//MOVEMENT
		Vector3 move = new Vector3(controller.move.x * Time.deltaTime * speed, controller.move.y * Time.deltaTime * speed, 0);
		gameObject.transform.Translate (move);

	}
}
