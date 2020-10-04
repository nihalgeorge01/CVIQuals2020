using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
	
	public Vector3 initialImpulse;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb.AddForce(initialImpulse, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
