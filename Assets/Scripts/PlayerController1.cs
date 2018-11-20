using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {
    private Rigidbody m_rb;
    public float speed = 10.0F;
    public float max_speed = 12.0F;
    float jump_height = 300.0F;
    private Collider m_collider;
    private float collide4r_radius = 0.0F;
    public float gronded_epsilon = 0.05F;
    public int user_layer_platform;
	// Use this for initialization
	void Start () {
        m_rb = GetComponent<Rigidbody>();
        m_collider = GetComponent<Collider>();
        collide4r_radius = m_collider.bounds.extents.y;

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
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
            m_rb.AddForce(0.0F, jump_height, 0.0F);
    }
    bool isGrounded()
    {
        int platform_layer = 1 << user_layer_platform;
        return Physics.Raycast(
            transform.position,
            Vector3.down,
            collide4r_radius + gronded_epsilon,
            platform_layer);
    }
}
