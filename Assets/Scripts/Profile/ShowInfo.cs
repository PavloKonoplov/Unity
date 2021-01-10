using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public GameObject Current;
    public GameObject Pevious;
    public GameObject CurrentText;
    public GameObject PerviousText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveCurrent()
    {
        Pevious.SetActive(false);
        PerviousText.SetActive(false);
        Current.SetActive(true);
        CurrentText.SetActive(true);
    }
}
