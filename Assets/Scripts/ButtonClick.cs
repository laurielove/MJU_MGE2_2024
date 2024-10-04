using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    [SerializeField]
    public string message;

    public void OnButtonClick()
    {
        Debug.Log(message);
    }
}
