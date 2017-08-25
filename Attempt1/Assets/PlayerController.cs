using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public static PlayerController Instance;



    public float TurnSpeed;
    public float BoostSpeed;


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

    
}
