using UnityEngine;
using System.Collections;

public class Scipt_Spawn_EnemyTest : MonoBehaviour {

	public float timer;
	public float delay;
	float positionY, prevPositionY;

	public GameObject enemy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		if (timer <= 0) 
		{
			positionY = Mathf.Round(Random.Range(-3.69f, 3.69f) * 1f);

			Instantiate(enemy, new Vector2 (12f, positionY), Quaternion.identity);
			timer = delay;
			//4.69 - -4.69
		}
	}
}
