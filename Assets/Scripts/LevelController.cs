using UnityEngine;
using UnityEngine.UI;
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

	private int health;
	public Text healthLabel;
	private int souls;
	public Text soulsLabel;
	private int mana;
	public Text manaLabel;

	// Use this for initialization
	void Start () {
		initialHazardCount = hazardCount;
		health = 20;
		souls = 100;
		mana = 100;

		healthLabel.text = health.ToString();
		soulsLabel.text = souls.ToString();
		manaLabel.text = mana.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startWaves() {
		GameObject.Find("StartButton").SetActive(false);
		StartCoroutine(spawnWaves());
	}

	public IEnumerator spawnWaves() {
		yield return new WaitForSeconds(startWait);

		while(waves > 0) {
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = waypoints[0].transform.position;
				Quaternion spawnRotation = Quaternion.identity;
				GameObject creepObject;

				if (i >= initialHazardCount) {
					creepObject = (GameObject)Instantiate(knight, spawnPosition, spawnRotation);
				}
				else {
					creepObject = (GameObject)Instantiate(peasant, spawnPosition, spawnRotation);
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
