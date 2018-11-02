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
	void FixedUpdate() {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            generateArrow();
        }
    }

    private void generateArrow()
    {
        Debug.Log("shoot!");
        Quaternion arrowQuaternion = new Quaternion(0, 0, 0, 0);
        Vector3 generatorPosition = player.transform.position;
        Instantiate(arrow, player.transform.position, arrowQuaternion);
    }
}
