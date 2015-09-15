using UnityEngine;
using System.Collections;

public class skeletonArcher : Tower {
    private float initalDamage = 4;
    private float initialFireRate = 2.0f;
    private float initialRange = 120;
    private bool flying = true;
    private float initialDoT = 2;

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
