using UnityEngine;
using System.Collections;

public class MoveShip : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    private float rotateDirection=1.0f;
    private bool move;
    private bool rotate;
    private bool forward;
	
	// Update is called once per frame
	void Update () {
        move = false;
        forward = true;
        rotate = false;

        Vector3 direction = new Vector3();

        if (Input.GetKey(KeyCode.S))
        {
            move = true;
            forward = true;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            move = true;
            forward = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rotateDirection = 1.0f;
            rotate = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rotateDirection = -1.0f;
            rotate = true;
        }

        if (move)
        {
            RaycastHit hit;
            bool didHit = Physics.Raycast(transform.position, direction, out hit, direction.magnitude);
            if (didHit)
            {
                transform.localPosition += (hit.distance * direction.normalized);

            }
            else {
                if (forward) {
                    transform.position += transform.forward * Time.deltaTime;
                }
                else { transform.position -= transform.forward * Time.deltaTime; }
  
            }
        }


        if (rotate) {
            Debug.Log("Rotating");
            Vector3 newAngle = transform.rotation.eulerAngles;
            newAngle.y += Time.deltaTime * rotateDirection * 40.0f;

            transform.rotation = Quaternion.Euler(0, newAngle.y, 0);
   
        }
    }
}
