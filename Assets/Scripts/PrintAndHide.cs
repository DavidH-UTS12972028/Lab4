using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;

    private int i = 0;
    private int rand;
    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ": " + i++);

        if (gameObject.tag == "Red" && i == 100)
            gameObject.SetActive(false);

        if (gameObject.tag == "Blue" && i == 100)
            rend.enabled = false;
    }
}
