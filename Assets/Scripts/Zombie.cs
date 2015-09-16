using UnityEngine;
using System.Collections;

public class Zombie : Tower {
    private float initalDamage = 8;
    private float initialFireRate = 1.0f;
    private float initialRange = 70;

	// Use this for initialization
	void Start () {
        this.damage = initalDamage;
        this.fireRate = initialFireRate;
        this.range = initialRange;
		this.gameObject.GetComponent<CircleCollider2D>().radius = initialRange / 100;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
