using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // The move speed
    public float moveSpeed = 10f;

    // The edge for movement
    public float leftAndRightEdge = 5.5f;

    // The main part of player which will be changed the rotation in future
    private Gua gua;

    // Use this for initialization
    void Start()
    {
        // Get the script
        gua = transform.Find("Mr_Gua").GetComponent<Gua>();
    }

    // Update is called once per frame
    void Update()
    {
        // get input to move the player object
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            // change the rotation depends on different direction
            gua.ChangeFace(false);
            Vector3 pos = transform.position;
            pos.x -= moveSpeed * Time.deltaTime;
            if (pos.x > -leftAndRightEdge)
            {
                transform.position = pos;
            }
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            // change the rotation depends on different direction
            gua.ChangeFace(true);
            Vector3 pos = transform.position;
            pos.x += moveSpeed * Time.deltaTime;
            if (pos.x < leftAndRightEdge)
            {
                transform.position = pos;
            }
        }
    }
}
