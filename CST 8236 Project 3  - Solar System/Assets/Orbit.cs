using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour {

    public float siderealPeriod;

    public bool retrograde;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float rotateDirection;
        if (retrograde)
        {
            rotateDirection = -1.0f;
        }
        else {
            rotateDirection = 1.0f;
        }

        //orbit around sun based on speed input
        transform.RotateAround(transform.parent.position, Vector3.up, Time.deltaTime/siderealPeriod*10.0f);
        //rotate on axis
        transform.Rotate(new Vector3(10, 20, 5), Time.deltaTime*rotateDirection*10.0f);

    }
}
