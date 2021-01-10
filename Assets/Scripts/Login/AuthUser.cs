
+using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class AuthUser : MonoBehaviour
{
    public InputField UsernameInput;
    public InputField PasswordInput;
    public int NextSceneID;
    
    string username;
    string password;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    bool Authorization(string username, string password)
    {
        //if (username == "Andriyko" && password == "12345" && email == "t@u.a")
        if (DataHolder.username.Contains(username) && DataHolder.password.Contains(password))
        {
            
            return true;
        }
        else
        {
            
            return false;
        }

    }

    public void MyFunction()
    {
        Debug.Log(UsernameInput.text);
        username = UsernameInput.text;
        password = PasswordInput.text;

        if (Authorization(username, password) == true)
        {
            Debug.Log("Hello my honey hello my darling");
            DataHolder.tipatoken = DataHolder.username.IndexOf(username);
            NextScene(NextSceneID);
        }
        else
        {
            
            Debug.Log("I don't know you!");

        }

    }
}



