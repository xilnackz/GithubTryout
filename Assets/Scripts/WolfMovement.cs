using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMovement : MonoBehaviour {

    public float toPosX;
    public float toPosY;
    public float time;

	// Use this for initialization
	void Start () {
        iTween.MoveTo(this.gameObject, iTween.Hash(
                                                    "x", toPosX,
                                                    "y", toPosY,
                                                    "time", time,
                                                    "easetype", "linear",
                                                    "looptype", "pingPong",
                                                    "onComplete", "FlipSprite"));

        if(this.gameObject.transform.position.x > toPosX)
        {
            FlipSprite();
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FlipSprite()
    {
        if(this.gameObject.GetComponent<SpriteRenderer>().flipX == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;

        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    { this.gameObject.GetComponent<AudioSource>().Play(); }
}
