using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changepanel : MonoBehaviour
{
    public GameObject panelToHide;
    public GameObject panelToShow;

    void Start()
    {
        // Invoke the method to change the panel after 8 seconds
        Invoke("ChangePanel", 8f);
    }

    void ChangePanel()
    {
        // Disable the current panel
        panelToHide.SetActive(false);

        // Enable the new panel
        panelToShow.SetActive(true);
    }
}
