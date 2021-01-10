using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTouch : MonoBehaviour
{

    public GameObject JustButton;
    public GameObject TouchButton;

    public void Touch()
    {
        JustButton.SetActive(false);
        TouchButton.SetActive(true);
    }

    public void Detouch()
    {
        JustButton.SetActive(true);
        TouchButton.SetActive(false);
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
