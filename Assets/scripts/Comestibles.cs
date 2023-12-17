using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comestibles : MonoBehaviour
{
    //Inicia programacion de los comestibles.-----------------------------------

    private void OnCollisionEnter(Collision collision) //Metodo para las coliciones....
    {
        if (collision.transform.CompareTag("Player"))
        {
            //Busca el metodo en Todos los scripts del proyecto.
            FindAnyObjectByType<GameManaguer>().addComestibles();
            Destroy(gameObject);// sirve para destruir el objeto entero....
        }
    }
}
