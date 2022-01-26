using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class MyScript : MonoBehaviour
{
    public TMP_Text MyText;

    public void MyFunction()
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        Debug.Log("Showing text");
        MyText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        Debug.Log("Hiding text");
        MyText.gameObject.SetActive(false);
    }
}