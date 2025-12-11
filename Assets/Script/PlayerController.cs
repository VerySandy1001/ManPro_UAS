using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{

    public AudioClip jumpSfx;
    public AudioClip coinSfx;

    public GameManager GameManager;
    public float jumpForce  = 10f;
    private Rigidbody2D rb;
    private bool isGrounded;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       GameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        { 
            if (isGrounded)
            {
                Jump();
                if (jumpSfx != null && audioSource != null)
                {
                    audioSource.PlayOneShot(jumpSfx);
                }
            }
        }
    }

    void Jump()
    { 
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;  
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            if (GameManager != null)
            {
                GameManager.MenambahScore();
            }
            if (coinSfx != null && audioSource != null)
            {
                audioSource.PlayOneShot(coinSfx);
            }
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Obstacle"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);   
        }
    }
}
