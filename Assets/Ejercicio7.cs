using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    public int num1 = 0;
    public int num2 = 0;
    public int num3 = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2 && num2 == num3)
        {
            Debug.Log("Los números son iguales");
        }
        else if (num1 > num2 && num1 > num3)
        {
            Debug.Log("El mayor número es " + num1);
        }
        else if (num2 > num1 && num2 > num3)
        {
            Debug.Log("El mayor número es " + num2);
        }
        else if (num3 > num2 && num3 > num1)
        {
            Debug.Log("El mayor número es " + num3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
