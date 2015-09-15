using UnityEngine;
using System.Collections.Generic;

public class Creep : MonoBehaviour {
	private double health;
	private double speed;
    private double souls;
    private bool flying = false;
    private bool magicImmune = false;
    private bool armor = false;
    private double DoT = 0;
    private List<GameObject> path;
    private int curDestination = 0;

	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	void Update () {
		}

	public double getHealth() {
		return this.health;
	}

	public void setHealth(double health) {
		this.health = health;
	}

	public double getSpeed() {
		return this.speed;
	}

	public void setSpeed(double speed) {
		this.speed = speed;
	}

    public double getSouls()
    {
        return this.souls;
    }

    public void setSouls(double souls)
    {
        this.souls = souls;
    }

    public bool getFlying()
    {
        return this.flying;
    }

    public void setFlying(bool flying)
    {
        this.flying = flying;
    }

    public bool getMagicImmune()
    {
        return this.magicImmune;
    }

    public void setMagicImmune(bool magicImmune)
    {
        this.magicImmune = magicImmune;
    }

    public bool getArmor() {
        return this.armor;
    }

    public void setArmor(bool armor) {
        this.armor = armor;
    }
        
   public double getDoT()
    {
        return this.DoT;
    }

    public void setDoT(double DoT)
    {
        this.DoT = DoT;
    }

    public List<GameObject> setPath()
    {
        return this.path;
    }

    public void getPath(List<GameObject> path)
    {
        this.path = path;
    }

    public int getCurDestination()
    {
        return this.curDestination;
    }

    public void setCurDestination(int curDestination) {
        this.curDestination = curDestination;
    }

}
