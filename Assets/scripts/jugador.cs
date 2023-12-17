using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private new Rigidbody rigidbody; // Gravedad.
    public float speed = 25f;
    private float moveHorizontal, moveVertical,saltar; // Variables de nivel de clase
    private bool enElSuelo = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>(); // Asigno la variable.
        rigidbody.useGravity = true; // Activar gravedad después de asignar el componente Rigidbody.
    }

    private void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        if (enElSuelo && Input.GetKeyDown(KeyCode.Space))
        {
            saltar = 20f;
            enElSuelo = false;
            StartCoroutine(EsperarYCaer());
        }

        Vector3 movement = new Vector3(moveHorizontal * speed, saltar, moveVertical * speed);

        IEnumerator EsperarYCaer()
        {
            yield return new WaitForSeconds(1f); // Esperar 1 segundo
            saltar = -20f; // Desactivar el salto para comenzar a caer
            enElSuelo = true;
        }

        rigidbody.velocity = movement;

    }
}
