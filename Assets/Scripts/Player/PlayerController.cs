using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Vector2 move;

	// Use this for initialization
	void Start () {
		move = Vector2.zero;
	}
	
	// Update is called once per frame
	void Update () {
		move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
	}
}
