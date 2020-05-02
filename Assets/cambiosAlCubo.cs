using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cambiosAlCubo : MonoBehaviour
{
    public static int puntaje = 0;
    public Text textoPuntaje;

    public void cambiarArojo()
    {

        Debug.Log("cambiar a rojo");
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    public void cambiarAverde()
    {

        Debug.Log("cambiar a rojo");
        this.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    public void matar()
    {
        //puntaje = puntaje + 1;
        puntaje++;
        textoPuntaje.text = puntaje.ToString();
        Debug.Log("mi puntaje es " + puntaje);

        Destroy(this.gameObject);
        evaluarGanar(puntaje);
    }


    private void evaluarGanar(int marcador)
    {
        if (marcador >= 5)
        {
            Debug.Log("gané!!!!");
          
        }
    }

}
