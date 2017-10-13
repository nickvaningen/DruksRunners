using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    [SerializeField]
    GameObject player;
    [SerializeField]
    Text scoreTextBox;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scoreTextBox.text = "Score: " + Mathf.Floor(player.transform.position.x).ToString();
	}
}
