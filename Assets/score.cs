using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public GameObject mur;
    public GameObject canvasthis;
  
    public static int sc = 0;
    private void Update()
    {
        if (sc == 4)
        {
            StartCoroutine(GoToLevel2());
        }
    }

    IEnumerator GoToLevel2()
    {
        yield return new WaitForSeconds(4f);
        Destroy(mur);
        Destroy(canvasthis);
    }

}
