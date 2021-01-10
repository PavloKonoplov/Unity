using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAppear : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Inputs;


    void Awake()
    {
        Inputs.GetComponent<Animation>().Play("TextApperar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
