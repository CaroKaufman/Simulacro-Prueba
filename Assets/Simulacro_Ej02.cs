//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible. 
//Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulacro_Ej02 : MonoBehaviour
{
    public float producto1, producto2, producto3, montoDisponible;
    
    void Start()
    {
        float suma = producto1 + producto2 + producto3;
        if ( suma > montoDisponible)
        {
            float falta = suma - montoDisponible;
            Debug.Log("La suma de los productos supera el monto indicado");
            Debug.Log("Faltan " + falta + "$");

        }

        if(suma< montoDisponible)
        {
            float sobra = montoDisponible - suma;
            Debug.Log("Sobran " + sobra + "$");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
