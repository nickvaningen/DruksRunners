using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_jup : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    private bool jumping;

    public bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        jumping = false;
        isGrounded = false;
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        if (!jumping)
        {
            isGrounded = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !jumping && isGrounded)
        {
            StopAllCoroutines();
            StartCoroutine("Jump");
        }
    }

    private IEnumerator Jump()
    {
        jumping = true;
        rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        for (float i = 0; i < 1 && Input.GetKey(KeyCode.Space); i += 1f / 60/*framerate*/ / 2/*amount of seconds*/)
        {
            isGrounded = false;
            rb.AddForce(jump * jumpForce/100, ForceMode.Impulse);
            yield return null;
        }
        jumping = false;
    }
}