using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {
    public GameObject gameOverText;
    public float RunSpeed;
    private bool isDead = false;
    private Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isDead == false)
        {
            if (Input.GetKey(KeyCode.A))
            {
                //transform.position += Vector3.left * speed * Time.deltaTime; // Shorthand of the line below
                transform.position = new Vector3(transform.position.x - RunSpeed *
                    Time.deltaTime, transform.position.y + RunSpeed *
                    Time.deltaTime, transform.position.z);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector3(transform.position.x + RunSpeed *
                    Time.deltaTime, transform.position.y + RunSpeed *
                    Time.deltaTime, transform.position.z);
            }
        
        }
    }
  void OnCollisionEnter2D()
    {
        isDead = true;
        GameCotrnol.instance.PlayerDied();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))// this is for destroing the Coins from the game if the colliders hit
        {
            Destroy(other.gameObject);
        }
    }

}
