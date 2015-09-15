using UnityEngine;
using System.Collections;

public class undeadMage : Tower {
    private double initalDamage = 4;
    private double initialFireRate = 1.0;
    private double initialRange = 120;
    private bool flying = true;
    private bool armorPen = true;
    private double initialSlow = 0.7;

    // Use this for initialization
    void Start()
    {
        this.setDamage(initalDamage);
        this.setFireRate(initialFireRate);
        this.setRange(initialRange);
        this.setArmorPen(armorPen);
        this.setDoT(initialSlow);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
