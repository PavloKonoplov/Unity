using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInformation : MonoBehaviour
{
    public Text Username;
    public Text University;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
        Username.text = DataHolder.username[DataHolder.tipatoken];
        University.text = DataHolder.University[DataHolder.tipatoken];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*GameObject GetChildWithName(string name)
    {
        Transform trans = transform;
        Transform childTrans = trans.Find(name);
        if (childTrans != null)
        {
            return childTrans.gameObject;
        }
        else
        {
            return null;
        }
    }*/
}
