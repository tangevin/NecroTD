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
    void Update () {
	
	}
}
