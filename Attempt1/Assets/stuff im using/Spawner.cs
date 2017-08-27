using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject[] SpawnPoints;

    public GameObject Asteriod;

    public GameObject Ball;

    public GameObject SpaceShip;

    public GameObject Capsule;

    public GameObject ScoreMultiplier;

    public Vector3 TopRight;
    public Vector3 BottomLeft;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnAsteroid()
    {
        int SpawnNumber = Random.Range(0, SpawnPoints.Length);
        Instantiate(Asteriod, SpawnPoints[SpawnNumber].transform.position, SpawnPoints[SpawnNumber].transform.rotation);
    }

    public void SpawnBall()
    {
        int SpawnNumber = Random.Range(0, SpawnPoints.Length);
        Instantiate(Ball, SpawnPoints[SpawnNumber].transform.position, SpawnPoints[SpawnNumber].transform.rotation);
    }

    public void SpawnSpaceShip()
    {
        int SpawnNumber = Random.Range(0, SpawnPoints.Length);
        Instantiate(SpaceShip, SpawnPoints[SpawnNumber].transform.position, SpawnPoints[SpawnNumber].transform.rotation);
    }

    public void SpawnCapsule()
    {
        int SpawnNumber = Random.Range(0, SpawnPoints.Length);
        Instantiate(SpaceShip, SpawnPoints[SpawnNumber].transform.position, SpawnPoints[SpawnNumber].transform.rotation);
    }

    public void SpawnMultiplier()
    {
        int SpawnNumber = Random.Range(0, SpawnPoints.Length);
        Instantiate(ScoreMultiplier, SpawnPoints[SpawnNumber].transform.position, SpawnPoints[SpawnNumber].transform.rotation);
    }
}
