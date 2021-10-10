 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour {
    public Transform target;
    public float dampTime = 0.5f;
    private Vector3 velocity = Vector3.zero;

   
	
	
	void Update () {
        //transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);

        Vector3 point = Camera.main.WorldToViewportPoint(target.position);
        Vector3 delta = target.position - Camera.main.ViewportToWorldPoint(new Vector3(point.x, 0.5f, point.z));
        Vector3 destination = transform.position + delta;
        transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);

    }
}
