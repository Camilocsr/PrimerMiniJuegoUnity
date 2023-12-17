using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManaguer : MonoBehaviour
{

    public TMP_Text numeroDeComestiblesConsumidos;
    private int numeroDeComestibles;

    
    void Start()
    {
        
    }

    
    void Update()
    {

    }

    public void addComestibles()
    {
        numeroDeComestibles++;
        //almacena el numero de comestibles convirtiendo el numero en formato texto para poder mostrarlo.
        numeroDeComestiblesConsumidos.text = numeroDeComestibles.ToString();
    }
}
