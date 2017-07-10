using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gua : MonoBehaviour {

    // Speed to move
    public float moveSpeed = 10f;

    // The edge for move
    public float leftAndRightEdge = 5.5f;

    // init scores
    private int scoreOkita = 0;
    private int scoreKiyohime = 0;

    // Text to show the score
    private Text uiTextOkita;
    private Text uiTextKiyohime;

	// Use this for initialization
	void Start () {
        // Get Text to show the scores
        uiTextOkita = GameObject.Find("Canvas/ScoreOkita").GetComponent<Text>();
        uiTextKiyohime = GameObject.Find("Canvas/ScoreKiyohime").GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {

    }

    // rotated the picture when the move direction is changed
    public void ChangeFace(bool direction)
    {
        Quaternion rot = transform.rotation;
        if (direction)
        {
            rot.y = 0;
        }
        else
        {
            rot.y = 180;
        }
        transform.rotation = rot;
    }

    // update the score and delete the object that collide
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collideWith = collision.gameObject;
        if(collideWith.tag == "Miss_Okita")
        {
            Destroy(collideWith);
            scoreOkita++;
            uiTextOkita.text = "捡了  " + scoreOkita + "  个冲田小姐姐";
        }

        if (collideWith.tag == "Kiyohime")
        {
            Destroy(collideWith);
            scoreKiyohime++;
            uiTextKiyohime.text = "捡了  " + scoreKiyohime + "  个清姬小姐姐";
        }
    }
}
