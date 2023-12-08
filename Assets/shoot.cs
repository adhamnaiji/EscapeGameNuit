using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shoot : MonoBehaviour
{
    public GameObject place;
    public Rigidbody projectile;

    public float speed = 20; 

    public InputActionProperty primaryButton;
    public float presedbuttonprimary;


    private void Update()
    {
        presedbuttonprimary = primaryButton.action.ReadValue<float>();

        if ((presedbuttonprimary > 0.7f))
        {

            //particle system tespawny
            Debug.Log("thrab mrgl");
            Rigidbody instantiatedProjectile = Instantiate(projectile, place.transform.position, place.transform.rotation) as Rigidbody;
            //instantiatedProjectile.velocity =transform.TransformDirection(Vector3.forward * 100);
            instantiatedProjectile.AddForce(Vector3.forward * 700);
        }
    }

     }
        
        // Debug.Log(presedbuttonprimary);
        //Debug.Log(liquid.activeInHierarchy);



