using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

    public float horizontalSpeed = 5.0f;
    public float arrowSpeed = 5.0f;
    public float jumpModifier = 5.0f;
    public float maxSpeed = 10.0f;

    private new Rigidbody2D rigidbody2D;
    private GameObject player;

    // Use this for initialization
    void Start () {
        this.rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate() {
        var speed = this.maxSpeed * arrowSpeed;
        var moveSpeed = new Vector2(speed, horizontalSpeed);
        var jumpForce = new Vector2(0, this.jumpModifier);

        this.rigidbody2D.velocity = moveSpeed;
        this.rigidbody2D.AddForce(jumpForce, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "GameBoundry")
        {
            Destroy(this.gameObject);
        }
    }
}
