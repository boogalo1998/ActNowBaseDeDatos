using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUser : MonoBehaviour
{
    private string UrlLeer = "http://tadeolabhack.com:8081/test/Datos/ActNowPhp/leerActNow.php";



    public Text TextoNombre;


    public int Cedula = 1032496725;

    public void obtenerInfo()
    {
        StartCoroutine(datos());
    }

    public IEnumerator datos()
    {
        string info = UrlLeer + "?cedu=" + Cedula;

        WWW resultInfo = new WWW(info);

        yield return resultInfo;

        print(resultInfo.text);

        TextoNombre.text = resultInfo.text;




    }






}