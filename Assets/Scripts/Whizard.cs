using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whizard : MonoBehaviour
{
    [SerializeField]
    private float jumpForce = 2.0f;

    public int snitch_counter = 0;

   [SerializeField]
    private Rigidbody2D rb;

    private string SNITCH_TAG = "Snitch"; 

    public AudioSource snitchSound;  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        snitchSound = GetComponent<AudioSource>();
    }

    void OnJump()
    {
        rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetButtonDown("Jump"))
        // {
        //     rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        // }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag(SNITCH_TAG))
        {
            snitchSound.Play();
            snitch_counter++;
            Destroy(col.gameObject);
        }
    }
}
