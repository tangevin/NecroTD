using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelController : MonoBehaviour {
	public int waves;
	public float spawnWait;
	public float waveWait;
	public float startWait;
	public int hazardCount;
	private int initialHazardCount;
	public List<GameObject> waypoints;

	public GameObject peasant;
	public GameObject knight;

	// Use this for initialization
	void Start () {
		initialHazardCount = hazardCount;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startWaves() {
		StartCoroutine(spawnWaves());
	}

	public IEnumerator spawnWaves() {
		yield return new WaitForSeconds(startWait);

		while(waves > 0) {
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = waypoints[0].transform.position;
				Quaternion spawnRotation = Quaternion.identity;
				Transform creepTransform;

				if (i > initialHazardCount) {
					creepTransform = Instantiate(knight, spawnPosition, spawnRotation) as Transform;
				}
				else {
					creepTransform = Instantiate(peasant, spawnPosition, spawnRotation) as Transform;
				}

				Creep creep = creepTransform.gameObject.GetComponent<Creep>();
				creep.setPath(waypoints);

				yield return new WaitForSeconds(spawnWait);
			}

			hazardCount++;
			waves--;
			yield return new WaitForSeconds(waveWait);
		}
	}
}
