using UnityEngine;
using System.Collections;

public class Knight : Creep {
    private double initialHealth = 30;
    private double initialSpeed = 1.5;
    private double souls = 200;
    private bool armor = true;

	// Use this for initialization
	void Start () {
        this.setHealth(initialHealth);
        this.setSpeed(initialSpeed);
        this.setSouls(souls);
        this.setArmor(armor);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
