using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += transform.forward * Time.deltaTime;
            transform.position -= transform.up * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.position -= transform.forward * Time.deltaTime;
            transform.position += transform.up * Time.deltaTime;
        }
    }
}
