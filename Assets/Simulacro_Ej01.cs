//1.Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulacro_Ej01 : MonoBehaviour
{
    public int num1, num2;
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los numeros ingresados son iguales");
        }
        else
        {
            Debug.Log("Los numeros no son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
