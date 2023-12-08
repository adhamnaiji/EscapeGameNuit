using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetoward : MonoBehaviour
{
    public Transform player; // Référence vers le joueur

    public float speed = 5.0f; // Vitesse de déplacement

    void Update()
    {
        // Assurez-vous que le joueur est défini
        
            // Calculez la direction vers le joueur
            Vector3 direction = player.position - transform.position;
            direction.Normalize(); // Normalisez le vecteur pour obtenir une direction

            // Déplacez l'objet vers le joueur
            transform.Translate(direction * speed * Time.deltaTime);
        
    }
}
