using UnityEngine;
using System.Collections.Generic;

public class Creep : MonoBehaviour {
	protected float health;
	protected float speed;
    protected float souls;
    protected bool flying = false;
    protected bool magicImmune = false;
    protected bool armor = false;
    protected float DoT = 0;
    protected List<GameObject> path;
    protected int curDestination = 0;
    protected Vector3 target; //for movement

	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	public void Update () {
        if (this.health <= 0)
        {
            creepDeath();
        }

        if (Vector3.Distance(this.transform.position, target) < 0.01)
        {
            this.curDestination++;
            if (this.curDestination >= this.path.Count)
            {
                Destroy(this.gameObject);
                return;   //Eventually this will be victory condition
            }
            this.target = this.setDestination();
        }

        float step = this.speed * Time.deltaTime;
        this.transform.position = Vector3.MoveTowards(this.transform.position, this.target, step);

    }

    public void creepDeath()
    {
        Destroy(this.gameObject);
    }

    public Vector3 setDestination()
    {
        return this.path[this.curDestination].transform.position;
    }

    public float getHealth() {
		return this.health;
	}

	public void setHealth(float health) {
		this.health = health;
	}

	public float getSpeed() {
		return this.speed;
	}

	public void setSpeed(float speed) {
		this.speed = speed;
	}

    public float getSouls()
    {
        return this.souls;
    }

    public void setSouls(float souls)
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
        
   public float getDoT()
    {
        return this.DoT;
    }

    public void setDoT(float DoT)
    {
        this.DoT = DoT;
    }

    public List<GameObject> getPath()
    {
        return this.path;
    }

    public void setPath(List<GameObject> path)
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
