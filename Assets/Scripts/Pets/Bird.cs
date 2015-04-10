using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

	public Player player;
	public int flyLength = 5;

	// Use this for initialization
	void Start () {
		player = GetComponent<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Ability() {
		Debug.Log ("ABILITY CALLED");
		for (int i  = 0; i < flyLength; i++) {
			if(player.dir == 0) {
				if(Physics2D.Raycast((Vector2)player.gameObject.transform.position, new Vector2(0, i), i, player.outerWalls)) {
					
				}
			} else if(player.dir == 1) {
				if(Physics2D.Raycast((Vector2)player.gameObject.transform.position, new Vector2(i, 0), i, player.outerWalls)) {
					
				}
			} else if(player.dir == 2) {
				if(Physics2D.Raycast((Vector2)player.gameObject.transform.position, new Vector2(0, -i), i, player.outerWalls)) {
					
				}
			} else if(player.dir == 3) {
				if(Physics2D.Raycast((Vector2)player.gameObject.transform.position, new Vector2(-i, 0), i, player.outerWalls)) {
					
				}
			}
		}
	}
}
