using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletFire : MonoBehaviour {
    public float FlySpeed;
    public float LifeTime;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, LifeTime);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * FlySpeed * Time.deltaTime;
	}

    void OnCollisionEnter( Collision other)
    {
        if (other.gameObject.tag == "Asteroid")
        {
            other.gameObject.GetComponent<Asteroid>().Die();
        }

        if (other.gameObject.tag == "Score")
        {
            other.gameObject.GetComponent<Asteroid>().Die();
        }
    }
}
