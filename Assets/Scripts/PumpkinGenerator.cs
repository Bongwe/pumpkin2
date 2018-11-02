using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinGenerator : MonoBehaviour {

    public Rigidbody2D pumpkin;
    public float time;
    public float repeatRate;
    public float gameWindowLeft = -3.0f;
    public float gameWindowRight = 8.0f;

    private GameObject pumpkinGenerator;

    // Use this for initialization
    void Start () {
        pumpkinGenerator = GameObject.FindWithTag("PumpkinGenerator");
        InvokeRepeating("CreatePumpkin", time, repeatRate);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    private void FixedUpdate()
    {
        
    }

    void CreatePumpkin()
    {
        float xPosition = Random.Range(gameWindowLeft, gameWindowRight);
        Vector3 generatorPosition = pumpkinGenerator.transform.position;
        Vector3 pumpkinPosition = new Vector3(xPosition, generatorPosition.y, generatorPosition.z);
        Instantiate(pumpkin, pumpkinPosition, new Quaternion());
    }
}
