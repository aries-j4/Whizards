using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayGameOver : MonoBehaviour
{
    public Whizard wz;
    public Text show;
    // Start is called before the first frame update
    void Start()
    {
        show = GetComponent<Text>();
        show.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!wz)
        {
            show.enabled = true;
        }
    }
}
