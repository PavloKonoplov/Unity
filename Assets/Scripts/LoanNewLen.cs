using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoanNewLen : MonoBehaviour
{
    private float step = 0.7f;
    private int sceneID;
    public GameObject Wave;
    public GameObject Pevious;


    public void NextScene(int SceneID)
    {
        sceneID = SceneID;
        StartCoroutine(TimeWaitNextScene());
        Wave.GetComponent<Animation>().Play("Wave2GoDown");
        Pevious.SetActive(false);

    }

    public void LoadS(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
        Wave.GetComponent<Animation>().Play("Wave2GoDown");
    }

    IEnumerator TimeWaitNextScene()
    {
        yield return new WaitForSeconds(step);
        SceneManager.LoadScene(sceneID);
    }

    void Update()
    {
        
    }
}



/*public class LoanNewLen : MonoBehaviour
{


    public void NextScene(int sceneID);
    private float step = 1.0f;

    {
        //yield WaitForSeconds(3);
        StartCoroutine(TimeWaitNextScene(3);
        SceneManager.LoadScene(sceneID);
    }

    IEnumerator TimeWaitNextScene(int s)
    {
        yield return new WaitForSeconds(s);
    }
}
*/