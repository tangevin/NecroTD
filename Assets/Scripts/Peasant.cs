using UnityEngine;
using System.Collections;

public class Peasant : Creep {
	private float initialHealth = 20;
	private float initialSpeed = 1.0f;

    // Use this for initialization
    void Start () {
		this.health = initialHealth;
		this.speed = initialSpeed;
        this.souls = 100;
        this.target = this.setDestination();  
	}
	
	// Update is called once per frame
    
}
