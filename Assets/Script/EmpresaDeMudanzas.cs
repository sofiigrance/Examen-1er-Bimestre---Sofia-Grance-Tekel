using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpresaDeMudanzas : MonoBehaviour
{
    // 1. Definición de variables

    public int cantidadKm;
    public string tipoAuto;
    int kilomentorsTotal;
    int precioFinal;
    float costoPorKm;
    int autoUtilitario = 3000;
    int autoPickup = 4500;
    int autoCamion = 7000;

    //Errores y cosas que faltan: Tipo auto no deberia ingresarse, solo mostrar en consola al final. 
    // 3. Procesamiento de datos
    // 4. Salida de datos.
    void Start()
    {
        // 2. Validación de datos

        if (cantidadKm < 100 || cantidadKm > 50)
        {
            Debug.Log("Error al ingresar la cantidad de kilometros.");
            return;
        }


        // 4. Salida de datos

        Debug.Log("Para este trayecto se necesita" + tipoAuto);

        Debug.Log("Costo total: $" + precioFinal);


        // Update is called once per frame
        void Update()
        {

        }
    }
}
