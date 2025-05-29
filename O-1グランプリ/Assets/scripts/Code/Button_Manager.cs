using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Manager : MonoBehaviour
{
    private int Counter;
    public void OnClick()
    {
        Counter++;
        Debug.Log($"Counter = {Counter}");
    } 
}
