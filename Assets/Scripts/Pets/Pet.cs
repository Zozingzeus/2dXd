using UnityEngine;
using System.Collections;

public class Pet : MonoBehaviour {

	public float cooldown;
	public float cooldownTime = 5;
	public GameObject[] pets;
	public GameObject curPet;

	// Use this for initialization
	void Start () {
		cooldown = Time.time;	
		curPet = pets [0];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UsePet() {
		curPet.GetComponent<Bird>().Ability();
		Debug.Log("Working");

	}

	public void Ability() {

	}
}
