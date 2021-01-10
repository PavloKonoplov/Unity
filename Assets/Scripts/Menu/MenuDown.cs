using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDown : MonoBehaviour
{
    private float step = 0.35f;
    //private int sceneID;
    public GameObject Wave;
    

    public void DownMenu()
    {
        //sceneID = SceneID;
        Debug.Log("Down!");

        StartCoroutine(TimeWaitNextScene());
        Wave.GetComponent<Animation>().Play("MenuDown");

    }

    IEnumerator TimeWaitNextScene()
    {
        yield return new WaitForSeconds(step);
        //SceneManager.LoadScene(sceneID);
    }
}
