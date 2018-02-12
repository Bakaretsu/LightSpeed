using UnityEngine;
using System.Collections;

public class Script_EnemySpawn : MonoBehaviour {
	public GameObject basicEnemy;
	public GameObject speederEnemy;
	public GameObject gatlingEnemy;
	// Use this for initialization
	void Start () 
	{
		StartCoroutine ("Wave");

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	public IEnumerator Wave()
	{
		yield return new WaitForSeconds (11f);
		Debug.Log (Time.time);
		Instantiate (basicEnemy, new Vector2 (10.76f, 0.22f), Quaternion.identity);
		yield return new WaitForSeconds (5f);
		Instantiate (basicEnemy, new Vector2 (10.76f, 2.02f), Quaternion.identity);
		Instantiate (basicEnemy, new Vector2 (10.76f, -3.68f), Quaternion.identity);
		yield return new WaitForSeconds (2f);
		Instantiate (basicEnemy, new Vector2 (10.76f, 0.22f), Quaternion.identity);
		Instantiate (basicEnemy, new Vector2 (10.76f, -1.73f), Quaternion.identity);
		yield return new WaitForSeconds (4f);
		Instantiate (speederEnemy, new Vector2 (0f, -1.73f), Quaternion.identity);
		Instantiate (speederEnemy, new Vector2 (0f, 0.22f), Quaternion.identity);
		yield return new WaitForSeconds (1f);
		Instantiate (speederEnemy, new Vector2 (0f, 2.02f), Quaternion.identity);
		Instantiate (speederEnemy, new Vector2 (0f, -3.68f), Quaternion.identity);

		yield return new WaitForSeconds (1f);
		Instantiate (speederEnemy, new Vector2 (0f, 2.02f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, 0.22f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, -1.73f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, -3.68f), Quaternion.identity);

		yield return new WaitForSeconds (1f);
		Instantiate (speederEnemy, new Vector2 (0f, 2.02f), Quaternion.identity);
		yield return new WaitForSeconds (0.25f);
		Instantiate (speederEnemy, new Vector2 (0f, 0.22f), Quaternion.identity);
		yield return new WaitForSeconds (0.25f);
		Instantiate (speederEnemy, new Vector2 (0f, -1.73f), Quaternion.identity);
		yield return new WaitForSeconds (0.25f);
		Instantiate (speederEnemy, new Vector2 (0f, -3.68f), Quaternion.identity);
		yield return new WaitForSeconds (0.25f);
		Instantiate (speederEnemy, new Vector2 (0f, -1.73f), Quaternion.identity);
		yield return new WaitForSeconds (0.25f);
		Instantiate (speederEnemy, new Vector2 (0f, -0.22f), Quaternion.identity);
		yield return new WaitForSeconds (0.25f);
		Instantiate (speederEnemy, new Vector2 (0f, 2.02f), Quaternion.identity);
			
		yield return new WaitForSeconds (3f);
		Instantiate (basicEnemy, new Vector2 (10.76f, 2.02f), Quaternion.identity);
		yield return new WaitForSeconds (1f);
		Instantiate (basicEnemy, new Vector2 (10.76f, 0.22f), Quaternion.identity);
		yield return new WaitForSeconds (1f);
		Instantiate (basicEnemy, new Vector2 (10.76f, -1.73f), Quaternion.identity);
		yield return new WaitForSeconds (1f);
		Instantiate (basicEnemy, new Vector2 (10.76f, -3.68f), Quaternion.identity);

		yield return new WaitForSeconds (7f);
		Instantiate (basicEnemy, new Vector2 (10.76f, 0.22f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, 0.22f), Quaternion.identity);

		Debug.Log (Time.time);
		yield return new WaitForSeconds (5f);
		Instantiate (gatlingEnemy, new Vector2 (10.76f, 0.22f), Quaternion.identity);

		yield return new WaitForSeconds (8.5f);
		Instantiate (gatlingEnemy, new Vector2 (10.76f, 2.02f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (gatlingEnemy, new Vector2 (10.76f, 0.22f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (gatlingEnemy, new Vector2 (10.76f, -1.73f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (gatlingEnemy, new Vector2 (10.76f, -3.68f), Quaternion.identity);
		Debug.Log (Time.time);

		yield return new WaitForSeconds (11f);
		Instantiate (basicEnemy, new Vector2 (10.76f, 2.02f), Quaternion.identity);
		Instantiate (basicEnemy, new Vector2 (10.76f, -3.68f), Quaternion.identity);
		yield return new WaitForSeconds (1f);
		Instantiate (speederEnemy, new Vector2 (0f, 0.22f), Quaternion.identity);
		Instantiate (speederEnemy, new Vector2 (0f, -1.73f), Quaternion.identity);

		yield return new WaitForSeconds (5f);
		Instantiate (basicEnemy, new Vector2 (10.76f, 0.22f), Quaternion.identity);
		Instantiate (basicEnemy, new Vector2 (10.76f, -1.73f), Quaternion.identity);
		yield return new WaitForSeconds (1f);
		Instantiate (speederEnemy, new Vector2 (0f, 2.02f), Quaternion.identity);
		Instantiate (speederEnemy, new Vector2 (0f, -3.68f), Quaternion.identity);
		Debug.Log (Time.time);

		yield return new WaitForSeconds (4f);
		Instantiate (speederEnemy, new Vector2 (0f, 0.22f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, -1.73f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, 2.02f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, -3.68f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, -1.73f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, 2.02f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, 0.22f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, -3.68f), Quaternion.identity);

		yield return new WaitForSeconds (3f);
		Instantiate (basicEnemy, new Vector2 (10.76f, 0.22f), Quaternion.identity);
		Instantiate (basicEnemy, new Vector2 (10.76f, -1.73f), Quaternion.identity);
		yield return new WaitForSeconds (1f);
		Instantiate (speederEnemy, new Vector2 (0f, -0.22f), Quaternion.identity);;
		Instantiate (speederEnemy, new Vector2 (0f, -1.73f), Quaternion.identity);
		Instantiate (gatlingEnemy, new Vector2 (10.76f, 2.02f), Quaternion.identity);
		Instantiate (gatlingEnemy, new Vector2 (10.76f, -3.68f), Quaternion.identity);
		yield return new WaitForSeconds (3f);
		Instantiate (speederEnemy, new Vector2 (0f, 2.02f), Quaternion.identity);;
		Instantiate (speederEnemy, new Vector2 (0f, -3.68f), Quaternion.identity);

		yield return new WaitForSeconds (5f);
		Instantiate (speederEnemy, new Vector2 (0f, 0.22f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, -1.73f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, 2.02f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, -3.68f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, -1.73f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, 2.02f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, 0.22f), Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		Instantiate (speederEnemy, new Vector2 (0f, -3.68f), Quaternion.identity);
		yield return new WaitForSeconds (1f);
		Instantiate (speederEnemy, new Vector2 (0f, 2.02f), Quaternion.identity);
		Instantiate (speederEnemy, new Vector2 (0f, 0.22f), Quaternion.identity);
		Instantiate (speederEnemy, new Vector2 (0f, -1.73f), Quaternion.identity);
		Instantiate (speederEnemy, new Vector2 (0f, -3.68f), Quaternion.identity);
	}

}

//2.02
//0.22
//-1.73
//-3.68