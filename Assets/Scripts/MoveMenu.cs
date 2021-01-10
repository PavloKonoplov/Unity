using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMenu : MonoBehaviour
{
    public GameObject MyCourses;
    public GameObject AllCourses;
    public GameObject obj;
    public float animationDuration;
    private Vector2 startPosition;
    private Vector2 targetPosition;

    void Start()
    {
        startPosition = obj.GetComponent<RectTransform>().anchoredPosition;
        targetPosition = obj.GetComponent<RectTransform>().anchoredPosition;
    }

    public void OpenMenu()
    {
        MyCourses.SetActive(false);
        AllCourses.SetActive(true);
        targetPosition.x = GetComponent<RectTransform>().anchoredPosition.x;
        StartCoroutine(Utils.MoveToTarget(obj.GetComponent<RectTransform>(), targetPosition, animationDuration));
    }

    public void CloseMenu()
    {
        MyCourses.SetActive(true);
        AllCourses.SetActive(false);
        targetPosition.x = GetComponent<RectTransform>().anchoredPosition.x;
        StartCoroutine(Utils.MoveToTarget(obj.GetComponent<RectTransform>(), targetPosition, animationDuration));
    }
}