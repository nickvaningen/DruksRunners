using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundLoop : MonoBehaviour {

    [SerializeField]
    private Image image1;
    [SerializeField]
    private Image image2;
    [SerializeField]
    private float speed;

    private float idk;

    // Use this for initialization
    void Start()
    {
        idk = 0;
	}
	
	// Update is called once per frame
	void Update()
    {
        idk += 0.01f;   
        MoveBackground();
    }

    void MoveBackground()
    {
        image1.rectTransform.anchorMin = new Vector2(idk % 1, 0);
        image1.rectTransform.anchorMax = new Vector2(idk % 1 + 1, 1);
        image2.rectTransform.anchorMin = new Vector2(idk % 1 - 1, 0);
        image2.rectTransform.anchorMax = new Vector2(idk % 1, 1);
    }
}
