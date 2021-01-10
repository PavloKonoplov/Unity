using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateUser : MonoBehaviour
{
    public InputField UsernameInput;
    public InputField EmailInput;
    public InputField PasswordInput;
    public InputField FirstNameInput;
    public InputField LastNameInput;
    public InputField UniversityInput;
    public int NextScene;
    string username;
    string password;
    string email;
    string FirstName;
    string LastName;
    string University;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool Authorization(string username, string password, string email)
    {
        //if (username == "Andriyko" && password == "12345" && email == "t@u.a")
        if (DataHolder.username.Contains(username) && DataHolder.password.Contains(password) && DataHolder.email.Contains(email))
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
        email = EmailInput.text;
        FirstName = FirstNameInput.text;
        LastName = LastNameInput.text;
        University = UniversityInput.text;

        DataHolder.username.Add(username);
        DataHolder.password.Add(password);
        DataHolder.email.Add(email);
        DataHolder.University.Add(University);
        DataHolder.LastName.Add(LastName);
        DataHolder.FirstName.Add(FirstName);

        Debug.Log(DataHolder.username[0]);

        
    }
}
