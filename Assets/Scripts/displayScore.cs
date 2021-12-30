using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayScore : MonoBehaviour
{
    public Whizard wz;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = wz.snitch_counter.ToString();
    }
}
