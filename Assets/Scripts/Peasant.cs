using UnityEngine;
using System.Collections;

public class Peasant : Creep {
	private float initialHealth = 20;
	private float initialSpeed = 2;
    private Vector3 target;

    // Use this for initialization
    void Start () {
		this.health = initialHealth;
		this.speed = initialSpeed;
        this.souls = 100;
        this.target = this.setDestination();  
	}
	
	// Update is called once per frame
	void Update () {

        if (Vector3.Distance(this.transform.position, target) < 0.1){
            this.curDestination++;
            if (this.curDestination >= this.path.Count)
            {
                Destroy(this);
                return;   //Eventually this will be victory condition
            }
            this.target = this.setDestination();
        }

        float step = this.speed * Time.deltaTime;
        this.transform.position = Vector3.MoveTowards(this.transform.position, this.target, step);
        
	}

    private Vector3 setDestination()
    {
        return this.path[this.curDestination].transform.position;
    }
}
