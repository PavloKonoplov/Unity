using Proyecto26;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEditor;
using UnityEngine.UI;

public class Authorization : MonoBehaviour
{

    public InputField UsernameInput;
    public InputField PasswordInput;

    public UnityEvent UnityEvent;

    private string username;


    private string password;
    public string token;

    public void Login()
    {
        username = UsernameInput.text;
        password = PasswordInput.text;

        //string get_url = "https://mediar-simple-auth.azurewebsites.net/api/user/login?username=" + username + "&" + "password=" + password;
        Debug.Log("https://mediar-simple-auth.azurewebsites.net/api/user/login?username=" + username + "&password=" + password);
        UnityEvent.Invoke();
        string get_url = "https://mediar-simple-auth.azurewebsites.net/api/user/login?username=" + username + "&password=" + password;


        RestClient.Get(get_url).Then(response =>
        {
            DataHolder.Token = response.Text;
            Debug.Log(DataHolder.Token);
        });
    }
}
