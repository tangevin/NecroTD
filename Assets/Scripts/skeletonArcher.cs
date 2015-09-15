using UnityEngine;
using System.Collections;

public class skeletonArcher : Tower {
    private double initalDamage = 4;
    private double initialFireRate = 2.0;
    private double initialRange = 120;
    private bool flying = true;
    private double initialDoT = 2;

    // Use this for initialization
    void Start()
    {
        this.setDamage(initalDamage);
        this.setFireRate(initialFireRate);
        this.setRange(initialRange);
        this.setFlying(flying);
        this.setDoT(initialDoT);
    }
    
    // Update is called once per frame
    void Update () {
	
	}
}
