using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buldger : MonoBehaviour
{
    private float speed_x;
    private Rigidbody2D rb;
    public AudioSource buldgerSound;

    private string WHIZARD_TAG = "Whizard";

    // Start is called before the first frame update
    void Start()
    {
        buldgerSound = GetComponent<AudioSource>();
        speed_x = Random.Range(9, 14);
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed_x, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag(WHIZARD_TAG))
        {
            buldgerSound.Play();
            Destroy(col.gameObject);
        }
    }

}
