using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class R2 : MonoBehaviour
{
    public TMP_Text scoretexte;
    public GameObject _2;


    public GameObject _r2;
    public MeshRenderer m;

    // Start is called before the first frame update
    void Start()
    {
        m = _2.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "2")
        {
            Debug.Log("hawna mrgl");
            m.enabled = true;
            Destroy(_r2);
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
