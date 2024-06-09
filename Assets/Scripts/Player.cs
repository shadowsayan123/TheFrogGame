using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    private bool isJumping = false;
    [SerializeField] float jumpForce;
    Rigidbody2D rb;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        // Left-Right movement
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (touchPos.x < 0)
            {
                rb.AddForce(Vector2.left * moveSpeed);
                sr.flipX = true;
            }
            else
            {
                rb.AddForce(Vector2.right * moveSpeed);
                sr.flipX = false;
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            rb.velocity = Vector2.zero;
        }

        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
    }
}
