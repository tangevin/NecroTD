using UnityEngine;
using System.Collections;

public class skeletonArcher : Tower {
    private float initalDamage = 4;
    private float initialFireRate = 2.0f;
    private float initialRange = 120;
    private float initialDoT = 2;

    // Use this for initialization
    void Start()
    {
        this.damage = initalDamage;
        this.fireRate = initialFireRate;
        this.range = initialRange;
        this.DoT = initialDoT;
		this.flying = true;
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
