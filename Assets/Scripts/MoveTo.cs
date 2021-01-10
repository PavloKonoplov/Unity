using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    public static IEnumerator MoveToTarget(RectTransform obj, Vector2 targetPosition, float animationDuration)
    {
        Vector2 startPosition = obj.anchoredPosition;
        float t = 0;

        while (t < 1)
        {
            obj.anchoredPosition = Vector2.Lerp(startPosition, targetPosition, t);
            t += Time.deltaTime / animationDuration;
            yield return null;
        }

        obj.anchoredPosition = targetPosition;
    }
}