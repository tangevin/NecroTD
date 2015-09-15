using UnityEngine;
using System.Collections;

public class Zombie : Tower {
    private float initalDamage = 8;
    private float initialFireRate = 1.0f;
    private float initialRange = 80;

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
