using UnityEngine;
using System.Collections;

public class Knight : Creep {
    private float initialHealth = 30;
    private float initialSpeed = 1.5f;

	// Use this for initialization
	void Start () {
        this.health = initialHealth;
        this.speed = initialSpeed;
        this.souls = 200;
        this.armor = true;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
