using UnityEngine;
using System.Collections;

public class undeadMage : Tower {
    private float initalDamage = 4;
    private float initialFireRate = 1.0f;
    private float initialRange = 120;
    private float initialSlow = 0.7f;

    // Use this for initialization
    void Start()
    {
        this.damage = initalDamage;
        this.fireRate = initialFireRate;
        this.range = initialRange;
        this.armorPen = true;
        this.slow = initialSlow;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
