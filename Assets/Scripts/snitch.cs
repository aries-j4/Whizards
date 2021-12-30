using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snitch : MonoBehaviour
{
    private float speed_x;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        speed_x = Random.Range(5, 9);
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed_x, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
