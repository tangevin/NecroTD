using UnityEngine;
using System.Collections.Generic;

public class Tower : MonoBehaviour {
    protected float damage;
    protected float fireRate;
    protected float atkCooldown = 0;
    protected float range;
    protected bool flying = false;
    protected bool armorPen = false;
    protected bool magic = false;
    protected float DoT = 0;
    protected float slow = 1.0f;
    protected bool splash = false;
    protected Creep curTarget;
    protected List<Creep> targetList;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public float getDamage()
    {
        return this.damage;
    }

    public void setDamage(float damage)
    {
        this.damage = damage;
    }

    public float getFireRate()
    {
        return this.fireRate;
    }

    public void setFireRate(float fireRate)
    {
        this.fireRate = fireRate;
    }

    public float getAtkCooldown()
    {
        return this.atkCooldown;
    }

    public void setAtkCooldown(float atkCooldown)
    {
        this.atkCooldown = atkCooldown;
    }

    public float getRangee()
    {
        return this.range;
    }

    public void setRange(float range)
    {
        this.range = range;
    }

    public bool getFlying()
    {
        return this.flying;
    }

    public void setFlying(bool flying)
    {
        this.flying = flying;
    }

    public bool getArmorPen()
    {
        return this.armorPen;
    }

    public void setArmorPen(bool armorPen)
    {
        this.armorPen = armorPen;
    }

    public bool getMagic()
    {
        return this.magic;
    }

    public void setMagic(bool magic)
    {
        this.magic = magic;
    }

    public float getDoT()
    {
        return this.DoT;
    }

    public void setDoT(float DoT)
    {
        this.DoT = DoT;
    }

    public float getSlow()
    {
        return this.slow;
    }

    public void setSlow(float slow)
    {
        this.slow = slow;
    }

    public bool getSplash()
    {
        return this.splash;
    }

    public void setSplash(bool splash)
    {
        this.splash = splash;
    }

    public Creep getCurTarget()
    {
        return this.curTarget;
    }

    public void setCurTarget(Creep curTarget)
    {
        this.curTarget = curTarget;
    }

    public List<Creep> getTargetList()
    {
        return this.targetList;
    }

    public void setTargetList(List<Creep> targetList)
    {
        this.targetList = targetList;
    }

}
