using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TypingText : MonoBehaviour
{
    [Range(0.01f,2)]
    public float speed;

    public Text textCom;
    public string fileText;
    int index;

  
    private void OnEnable()
    {
        index = 0;
        textCom.text = null;
        InvokeRepeating("InvokeMethod", 0, speed);
    }
    public void InvokeMethod()
    {
        index++;
        textCom.text = fileText.Substring(0, index);

        if (textCom.text.Length == fileText.Length)
        {     
            CancelInvoke();
        }
    }

}
