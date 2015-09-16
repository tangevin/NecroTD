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
        this.flying = true;
        this.armorPen = true;
		this.slow = initialSlow;
		this.gameObject.GetComponent<CircleCollider2D>().radius = initialRange;
	}
	
	// Update is called once per frame
	

  protected override void fireAway(Creep curTarget)
    {
        float health = curTarget.getHealth();
        health = health - this.damage;
        curTarget.setHealth(health);
    }

    protected override bool validTarget(Creep curTarget)
    {
        bool fly = this.flying || !curTarget.getFlying(); //true unless enemy is flying and tower is not
        bool mag = this.magic && curTarget.getMagicImmune(); //true if enemy is immune and tower is magic
        return fly && !mag;
    }
}
