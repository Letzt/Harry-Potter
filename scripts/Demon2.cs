using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Demon2 : MonoBehaviour
{
    private int j;
    public static int mins1;
    public static int sec1;
    public Text timerText;
    public float speed = 0.0001f;
    private float startTime;
    public float directionX = 1f;
    public float selector1;
    //public float selector2;

    // Vector3 stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

    Vector3 temppos;
    // Use this for initialization
    void Start()
    {

        selector1 = 0.5f;
        startTime = Time.time;
        //selector2 = 0.5f;
    }
    // Update is called once per frame
    void Update()
    {
        j = BulletScript2.k;
        if (j == 0)
        {
            return;
        }
        float t = Time.time - startTime;
        mins1 = ((int)t / 60);
        sec1 = (int)(t % 60);
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        timerText.text = minutes + ":" + seconds;
        temppos = transform.position;
        if (temppos.x <= -30f || temppos.x >= 30f)
        {
            directionX *= -1;
            //selector1 *= 1.5f;
        }
        temppos.x += (directionX * selector1);

        /*if (temppos.y <= 0f || temppos.y >= stageDimensions.y)
        {
            directionY *= -1;
            //selector2 *= 1.5f;
        }
        temppos.y += (directionY * selector2);*/

        transform.position = temppos;
    }
}
