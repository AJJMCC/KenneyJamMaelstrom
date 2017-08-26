using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public static PlayerController Instance;



    public float TurnSpeed;
    public float BoostSpeed;

    public GameObject Pellet;
    public GameObject Muzzle1;
    public GameObject[] Muzzles2;

    public float MuzzleCount = 1;
    


    //private float TurningLeft;
    //private float TurningRight;

	// Use this for initialization
	void Start () {
        Instance = this;
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckTurns();
        CheckThrust();
        CheckFire();
	}

    void CheckTurns()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0,0,1 * TurnSpeed * Time.deltaTime) ;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, 1 * -TurnSpeed * Time.deltaTime);
        }
    }

    void CheckThrust()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.GetComponent<Rigidbody>().AddForce(transform.up * BoostSpeed * Time.deltaTime);
        }
    }

    void CheckFire()
    {

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (MuzzleCount == 1)
            {
                Instantiate(Pellet,Muzzle1.transform.position, Muzzle1.transform.rotation);

            }
            if (MuzzleCount == 2)
            {
                foreach (GameObject Muzzle in Muzzles2)
                {
                    Instantiate(Pellet, Muzzle.transform.position, Muzzle.transform.rotation);
                }

            }
            if (MuzzleCount == 3)
            {
                foreach (GameObject Muzzle in Muzzles2)
                {
                    Instantiate(Pellet, Muzzle.transform.position, Muzzle.transform.rotation);
                }
                Instantiate(Pellet, Muzzle1.transform.position, Muzzle1.transform.rotation);
            }
        }
    }


    void HitDeath()
    {
        MuzzleCount = 1;
    }

    void HitPowerUp(GameObject other)
    {
        MuzzleCount = 3;
        Destroy(other);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PowerUp")
        {
            HitPowerUp(other.gameObject);
        }

        if (other.gameObject.tag == "Killer")
        {
            HitDeath();
        }
    }
}
