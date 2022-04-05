using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public string nombre3;

    public float capital1;
    public float capital2;
    public float capital3;

    float capitalTotal;
    float porc1;
    float porc2;
    float porc3;

    // Start is called before the first frame update
    void Start()
    {
        capitalTotal = capital1 + capital2 + capital3;

        porc1 = capital1 / capitalTotal * 100;
        porc2 = capital2 / capitalTotal * 100;
        porc3 = capital2 / capitalTotal * 100;

        Debug.Log("Nombre: " + nombre1 + ", capital aportado: $" + capital1 + ", porcentaje del capital: %" + porc1 + ", monto total aportado: $" + capitalTotal);

        Debug.Log("Nombre: " + nombre2 + ", capital aportado: $" + capital2 + ", porcentaje del capital: %" + porc2 + ", monto total aportado: $" + capitalTotal);

        Debug.Log("Nombre: " + nombre3 + ", capital aportado: $" + capital3 + ", porcentaje del capital: %" + porc3 + ", monto total aportado: $" + capitalTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
