using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {
    private Rigidbody m_rb;


	// Use this for initialization
	void Start () {
        m_rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float movement = Input.GetAxis("Horizontal");
        m_rb.AddForce(new Vector3(movement, 0.0F, 0.0F));
	}
}
