using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            //do some stuff before we destroy
            //Debug.Log("Ground");
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Arrow")
        {
            //do some stuff before we destroy
            //Debug.Log("Arrow");
            Destroy(this.gameObject);
        }
    }
}
