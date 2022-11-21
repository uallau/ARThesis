using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoButton : MonoBehaviour
{
    public GameObject Infobutton; 

    public void OpenPanel()
    {
        if (Infobutton != null)
        {
            bool isActive = Infobutton.activeSelf;

            Infobutton.SetActive(!isActive);
        }
    }
}

