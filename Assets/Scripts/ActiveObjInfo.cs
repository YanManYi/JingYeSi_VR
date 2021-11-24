using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObjInfo : MonoBehaviour
{


    bool isState;

    [Header("各拿各自的canvas")]
    public GameObject canvasInfo;

    private void Update()
    {
        if (isState)
        {

            canvasInfo.SetActive(true);


        }
        else
            canvasInfo.SetActive(false);
    }


    public void UpMedthod() { isState = true;  }
    public void ExitMedthod() { isState = false; }

}
