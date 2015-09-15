using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {
    private double damage;
    private double fireRate;
    private double atkCooldown = 0;
    private double range;
    private bool flying = false;
    private bool armorPen = false;
    private bool magic = false;
    private double DoT = 0;
    private double slow = 1.0;
    private bool splash = false;
    private Creep target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public double getDamage()
    {
        return this.damage;
    }

    public void setDamage(double damage)
    {
        this.damage = damage;
    }

    public double getFireRate()
    {
        return this.fireRate;
    }

    public void setFireRate(double fireRate)
    {
        this.fireRate = fireRate;
    }

    public double getAtkCooldown()
    {
        return this.atkCooldown;
    }

    public void setAtkCooldown(double atkCooldown)
    {
        this.atkCooldown = atkCooldown;
    }

    public double getRangee()
    {
        return this.range;
    }

    public void setRange(double range)
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

    public double getDoT()
    {
        return this.DoT;
    }

    public void setDoT(double DoT)
    {
        this.DoT = DoT;
    }

    public double getSlow()
    {
        return this.slow;
    }

    public void setSlow(double slow)
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

    public Creep getTarget()
    {
        return this.target;
    }

    public void setTarget(Creep target)
    {
        this.target = target;
    }

}
