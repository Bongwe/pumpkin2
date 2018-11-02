using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour {

    public Rigidbody2D arrow;
    public Rigidbody2D player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
            generateArrow();
    }

    private void generateArrow()
    {
        Quaternion arrowQuaternion = new Quaternion(0, 0, 0, 0);
        Vector3 arrowPosition = player.transform.position;
        Instantiate(arrow, arrowPosition, arrowQuaternion);
    }
}
