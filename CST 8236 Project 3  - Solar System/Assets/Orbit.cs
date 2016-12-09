using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour {

    public float siderealPeriod;
    public static float orbitSpeed = 21.0f;
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

        if (Input.GetKeyDown(KeyCode.Z))
        {
            orbitSpeed += 2.0f;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            if(orbitSpeed>2.0f){
                orbitSpeed -= 2.0f;
            }

        }


        if (transform.parent != null) {
            //orbit around sun based on speed input
            transform.RotateAround(transform.parent.position, Vector3.up, Time.deltaTime / siderealPeriod * orbitSpeed);
        }
            
        //rotate on axis
        transform.Rotate(new Vector3(10, 20, 5), Time.deltaTime*rotateDirection*10.0f);

    }
}
