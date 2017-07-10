using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miss_Okita : MonoBehaviour {

    // The min Y value
    public static float bottomY = -5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // destroy the object if it get far away
		if(transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
        }
	}
}
