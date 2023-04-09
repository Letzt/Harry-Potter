using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Broom2 : MonoBehaviour
{
    int currentSceneIndex;
    public Text ScoreText;
    public static int score1;
    public float speed = 200f;
    private Rigidbody rbody;
    // Use this for initialization
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        score1 = 0;
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        score1 = (int)(20.76 - transform.position.z);
        ScoreText.text = "Score :" + score1;

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(0, y, -x);
        if (transform.position.z < -11.0)
        {
            Application.LoadLevel(currentSceneIndex + 1);
        }

        //float movex = x * speed * Time.deltaTime;
        //float movey = y * speed * Time.deltaTime;
        // rbody.AddForce(0f,movey,-movex);
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision");
        if (col.gameObject.tag == "fall")
        {
            Destroy(gameObject);
            Application.LoadLevel(currentSceneIndex + 1);
        }
    }
    void OnCollisionStay(Collision col)
    {
        Debug.Log("Collision");
        if (col.gameObject.tag == "fall")
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionExit(Collision col)
    {
        Debug.Log("Collision");
        if (col.gameObject.tag == "fall")
        {
            Destroy(gameObject);
        }
    }
}
