using UnityEngine;
using System.Collections;

public class Zombie : Tower {
    private double initalDamage = 8;
    private double initialFireRate = 1.0;
    private double initialRange = 80;

	// Use this for initialization
	void Start () {
        this.setDamage(initalDamage);
        this.setFireRate(initialFireRate);
        this.setRange(initialRange);	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
