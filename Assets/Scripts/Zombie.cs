using UnityEngine;
using System.Collections;
using System;

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
	
	// Update is called once per frame. EXCEPT NOT!!!
    
    protected override void fireAway(Creep curTarget)
    {
        float health = curTarget.getHealth();
        health = health - this.damage;
        curTarget.setHealth(health);
        atkCooldown = 0;
        Debug.Log("Zombie attacked " + curTarget);
    }

    protected override bool validTarget(Creep curTarget)
    {
        bool fly = this.flying || !curTarget.getFlying(); //true unless enemy is flying and tower is not
        bool mag = this.magic && curTarget.getMagicImmune(); //true if enemy is immune and tower is magic
        return fly && !mag;
    }
}
