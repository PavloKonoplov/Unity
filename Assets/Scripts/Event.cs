/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Event : MonoBehaviour
{

    public delegate void SomeAction(int argument);

    public event SomeAction gameStartAction;
    // Start is called before the first frame update
    void Start()
    {
        gameStartAction?.Invoke(argument: 1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Create()
    {
        unityEvent.Invoke();
    }
}
*/