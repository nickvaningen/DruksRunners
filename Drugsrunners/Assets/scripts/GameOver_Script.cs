using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver_Script : MonoBehaviour {
    Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(transform.localPosition);
        if (transform.localPosition.x < -14 || transform.localPosition.y < -8 || transform.localPosition.y > 6)
        {
            Destroy(gameObject);
            Application.LoadLevel(0);
        }
    }
    
}
