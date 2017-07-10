using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour {

    // Two objects which will be thrown
    public GameObject okitaObj;
    public GameObject KiyohimeObj;

    // Speed for move
    public float speed = 4.0f;

    // Edge for movement
    public float leftAndRightEdge = 5.0f;

    // Chance for random change the direction
    public float chanceToChangeDirections = 0.01f;

	// Use this for initialization
	void Start () {
        // keep calling the function to drop two objects
        InvokeRepeating("RandomDrop", 1f, 0.6f);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;

        // move the object
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // change the picture's direction depends on speed
        if(speed > 0)
        {
            rot.y = 180;
        }
        else
        {
            rot.y = 0;
        }

        transform.rotation = rot;

        if(pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if(pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
	}

    // Random change the direction in fixed flames
    private void FixedUpdate()
    {
        if(Random.value < chanceToChangeDirections)
        {
            // change the direction
            speed *= -1;
        }
    }

    void DropOkita()
    {
        GameObject okita = Instantiate(okitaObj) as GameObject;
        Vector3 pos = this.transform.position;
        pos.y -= 1.2f;
        okita.transform.position = pos;
    }

    void DropKiyohime()
    {
        GameObject kiyohime = Instantiate(KiyohimeObj) as GameObject;
        Vector3 pos = this.transform.position;
        pos.y -= 1.2f;
        kiyohime.transform.position = pos;
    }

    void RandomDrop()
    {
        if (Random.value <= 0.5f)
        {
            DropKiyohime();
        }
        else
        {
            DropOkita();
        }
    }
}
