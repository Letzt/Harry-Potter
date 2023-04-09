using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour {

    Vector3 temppos;
    public static float t = 0.0f;
    float y;
    // Use this for initialization
    void Start ()
    { 
        y = Random.Range(0.05f, 0.1f);
    }
	
	// Update is called once per frame
	void Update () {
        temppos = transform.position;
        temppos.y -= y;
        if (temppos.y <= 0f)
        {
            temppos.y = 17.5f;
        }
        transform.position = temppos;
    }
}
