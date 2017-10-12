using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    [SerializeField]
    private float speed;
    private float distance;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        move();
    }

    private void move()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        Debug.Log(transform.position.x);
    }

    public float getSpeed()
    {
        return speed;
    }

    public float getDistance()
    {
        return distance;
    }
}
