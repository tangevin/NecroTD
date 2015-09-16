using UnityEngine;
using System.Collections;

public class Knight : Creep {
    private float initialHealth = 30;
    private float initialSpeed = 0.75f;

	// Use this for initialization
	void Start () {
        this.health = initialHealth;
        this.speed = initialSpeed;
        this.souls = 200;
        this.armor = true;
        this.target = this.setDestination();

    }
	
	// Update is called once per frame

}
