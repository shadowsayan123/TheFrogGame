using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    // public GameObject Player;
    private bool shouldMove = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldMove)
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log(collision.gameObject.name + " started colliding with us");
            shouldMove = false;
        }
    }
}
