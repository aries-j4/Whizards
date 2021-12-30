using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployObjects : MonoBehaviour
{
    public GameObject snitch, buldger;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SnitchGenerator());
        StartCoroutine(BuldgerGenerator());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void snitchSpawner()
    {
        GameObject sn = Instantiate(snitch) as GameObject;
        sn.transform.position = new Vector2(11f, Random.Range(-3, 5));
    }
    void buldgerSpawner()
    {
        GameObject bd = Instantiate(buldger) as GameObject;
        bd.transform.position = new Vector2(11f, Random.Range(-3, 5));
    }
    IEnumerator SnitchGenerator()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(5, 7));
            snitchSpawner();
        }
    }
    IEnumerator BuldgerGenerator()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(2, 6));
            buldgerSpawner();
        }
    }
}
