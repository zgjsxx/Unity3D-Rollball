using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody rd;
    public int score = 0;
    public Text scoreText;
    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("game starts");
        rd = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //rd.AddForce(Vector3.right);
        float h = Input.GetAxis("Horizontal");//[-1, 1]
        float v = Input.GetAxis("Vertical");
        Debug.Log(h);
        rd.AddForce(new Vector3(h, 0, v));
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
        }
    }
    */
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
        {
            Destroy(other.gameObject);
            score++;
            scoreText.text = "score: " + score;
        }
        if (score == 12)
        {
            winText.SetActive(true);
        }
    }
    
}
