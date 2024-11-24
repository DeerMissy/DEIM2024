using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZombie : MonoBehaviour
{
    private void OnTriggerEnter(Collider infoAcces)
    {
        //Identificar a los zombies mediante una etiqueta "Enemies"
        if (infoAcces.CompareTag("Attack"))
        {
            // Eliminar el zombie al ser golpeado
            Destroy(gameObject);


        }

    }
}