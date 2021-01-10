using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAppear : MonoBehaviour
{
    //public GameObject Inputs;
    public GameObject Menu;


    public void OpenMenu()   
    {
        Debug.Log("Open Down!");

        Menu.GetComponent<Animation>().Play("MenuArrive");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
