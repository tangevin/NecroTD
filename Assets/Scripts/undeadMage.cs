using UnityEngine;
using System.Collections;

public class undeadMage : Tower {
    private float initalDamage = 4;
    private float initialFireRate = 1.0f;
    private float initialRange = 120;
    private bool flying = true;
    private bool armorPen = true;
    private float initialSlow = 0.7f;

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
