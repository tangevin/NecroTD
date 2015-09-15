using UnityEngine;
using System.Collections;

public class Peasant : Creep {
	private double initialHealth = 20;
	private double initialSpeed = 2;
    private double souls = 100;
    
	// Use this for initialization
	void Start () {
		this.setHealth(initialHealth);
		this.setSpeed(initialSpeed);
        this.setSouls(souls);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
