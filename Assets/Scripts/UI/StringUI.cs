using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class StringUI : MonoBehaviour
{
    public TMP_Text text = null;
    public StringData data = null;


    private void OnValidate()
    {
        if (data != null)
        {
            name = data.name;
            text.text = name;
        }
    }

    void Update()
    {
        text.text = data.value;
    }



    void UpdateValue(string value)
    {
        data.value = value;
    }
}