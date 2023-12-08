using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class R3 : MonoBehaviour
{
    public TMP_Text scoretexte;
    public GameObject _3;


    public GameObject _r3;
    public MeshRenderer m;

    // Start is called before the first frame update
    void Start()
    {
        m = _3.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "3")
        {
            Debug.Log("hawna mrgl");
            m.enabled = true;
            Destroy(_r3);
            score.sc += 1;
            scoretexte.SetText("Score :" + score.sc);
        }
        else
        {
            Debug.Log("wrong");
            AudioSystem.Instance.PlaySFX("wrong");

        }

    }
}
