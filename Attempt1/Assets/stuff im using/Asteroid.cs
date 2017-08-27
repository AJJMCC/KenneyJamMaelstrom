using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

    public GameObject HalfAsteroid;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Die()
    {
        Instantiate(HalfAsteroid, this.transform.position, this.transform.rotation);
        Instantiate(HalfAsteroid, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
}
