using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextEnter : MonoBehaviour
{
    public GameObject PerviousEntering;
    public GameObject NextEntering;
    public GameObject Wave;
    // Start is called before the first frame update
    void Start()
    {
        //Wave.layer = 100;
    }

    public void ToNextEntering()
    {
        PerviousEntering.SetActive(false);

        Wave.GetComponent<Animation>().Play("Wave2GoDown");
        
        NextEntering.SetActive(true);
    }

}
