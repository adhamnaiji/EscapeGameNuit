using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ChooseTB : MonoBehaviour
{
    public GameObject panelchoose;
    public GameObject panelright;
    public GameObject panelloose;

    public void ChooseTaxi()
    {
        panelchoose.SetActive(false);
        panelright.SetActive(true);
        StartCoroutine(GoToTheLave());

    }

    public void Choosebus()
    {
        panelchoose.SetActive(false);
        panelloose.SetActive(true);
    }

    public void ReturnBack()
    {
        panelloose.SetActive(false);
        panelchoose.SetActive(true);

    }

    IEnumerator GoToTheLave()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(1);
    }
}
