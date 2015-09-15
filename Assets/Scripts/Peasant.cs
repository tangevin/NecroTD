using UnityEngine;
using System.Collections;

public class Peasant : Creep {
	private int initialHealth = 20;
	private int initialSpeed = 2;

	// Use this for initialization
	void Start () {
		this.setHealth(initialHealth);
		this.setSpeed(initialSpeed);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
