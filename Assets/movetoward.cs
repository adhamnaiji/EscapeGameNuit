using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetoward : MonoBehaviour
{
    public Transform player; // R�f�rence vers le joueur

    public float speed = 5.0f; // Vitesse de d�placement

    void Update()
    {
        // Assurez-vous que le joueur est d�fini
        
            // Calculez la direction vers le joueur
            Vector3 direction = player.position - transform.position;
            direction.Normalize(); // Normalisez le vecteur pour obtenir une direction

            // D�placez l'objet vers le joueur
            transform.Translate(direction * speed * Time.deltaTime);
        
    }
}
