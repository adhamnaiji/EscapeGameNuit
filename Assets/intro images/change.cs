using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    public GameObject panelToHide;
    public GameObject panelToShow;

    void Start()
    {
// Disable the current panel
        panelToHide.SetActive(true);

        // Enable the new panel
        panelToShow.SetActive(false);
        // Invoke the method to change the panel after 8 seconds
        Invoke("ChangePanel", 20f);
        //
        StartCoroutine(GoToScene0());

    }

    void ChangePanel()
    {
        // Disable the current panel
        panelToHide.SetActive(false);

        // Enable the new panel
        panelToShow.SetActive(true);
    }

    IEnumerator GoToScene0()
    {
        yield return new WaitForSeconds(30f);
        SceneManager.LoadScene(0);
    }
}
