using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {
    private Rigidbody m_rb;
    public float speed = 10.0F;
    public float max_speed = 4F;


	// Use this for initialization
	void Start () {
        m_rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update() {

    }

    private void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal");
        m_rb.AddForce(new Vector3(movement * speed, 
            0.0F, 0.0F));
        m_rb.velocity = new Vector3(
            Mathf.Clamp(m_rb.velocity.x, -max_speed, max_speed),
            m_rb.velocity.y,
            m_rb.velocity.z
            );
    }
}
