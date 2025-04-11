using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeladeriaLosTresGustos : MonoBehaviour
{
    public string sabor;
    public int cantidadDeHeladoGramos;
    int precioKilo = 1250;
    float precioFinal;
    void Start()
    {
        if (cantidadDeHeladoGramos > 3000 | cantidadDeHeladoGramos < 250)
        {
            Debug.Log("Error, la cantidad de helado tiene que ser mayor que 250g y menor que 3000g");
            return;
        }

        if (sabor == "CHO")
        {
            precioFinal = (cantidadDeHeladoGramos / 1000f) * precioKilo;
            Debug.Log("Eligio el sabor " + sabor + " y " + cantidadDeHeladoGramos + " gramos de helado, el precio final es: " + precioFinal);
        }

        else if (sabor == "FRU")
        {
            precioFinal = (cantidadDeHeladoGramos / 1000f) * precioKilo;
            precioFinal = precioFinal - precioFinal / 10;
            Debug.Log("Eligio el sabor " + sabor + " y " + cantidadDeHeladoGramos + " gramos de helado, aplicando el descuento, el precio final es: " + precioFinal);
        }

        else if (sabor == "DDL")
        {
            precioFinal = (cantidadDeHeladoGramos / 1000f) * precioKilo;
            Debug.Log("Eligio el sabor " + sabor + " y " + cantidadDeHeladoGramos + " gramos de helado, el precio final es: " + precioFinal);
        }

        else
        {
            Debug.Log("Error, el sabor solo puede ser CHO, FRU y DDL");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
