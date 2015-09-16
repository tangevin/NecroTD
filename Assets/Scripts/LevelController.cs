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
		startWaves();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startWaves() {
		StartCoroutine(spawnWaves());
	}

	public IEnumerator spawnWaves() {
		Debug.Log("Starting spawn");
		yield return new WaitForSeconds(startWait);
		Debug.Log ("start wait over");
		while(waves > 0) {
			Debug.Log ("Starting wave " + waves);
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = waypoints[0].transform.position;
				Quaternion spawnRotation = Quaternion.identity;
				GameObject creepObject;
				Debug.Log ("spawning enemy " + i + " at " + spawnPosition);

				if (i >= initialHazardCount) {
					creepObject = (GameObject)Instantiate(knight, spawnPosition, spawnRotation);
				}
				else {
					creepObject = (GameObject)Instantiate(peasant, spawnPosition, spawnRotation);
					Debug.Log(creepObject);
				}

				Creep creep = creepObject.GetComponent<Creep>();
				creep.setPath(waypoints);

				yield return new WaitForSeconds(spawnWait);
			}

			hazardCount++;
			waves--;
			yield return new WaitForSeconds(waveWait);
		}
	}
}
