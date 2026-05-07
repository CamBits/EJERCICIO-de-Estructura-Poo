using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class EstadoEmocional : MonoBehaviour
{

    //Atributes

    //Public
   
    public string efectoVisual;
    public string emocionActual;

    //Private
    private string[] tipo = { "feliz", "triste", "enojado", "neutral"};

    private float multiplicadorPoder;

   public string estadoActual()
    {
        int lista = Random.Range(0, tipo.Length);
        string emocionActual = tipo[lista];

        switch (emocionActual)
        {

            case "feliz":

                efectoVisual = "una luz radiante";
                multiplicadorPoder =1.5f ;
                break;

            case "triste":

                efectoVisual = "niebla azulada";
                multiplicadorPoder = 0.5f;
                break;

            case "enojado":

                efectoVisual = "nubes negras";
                multiplicadorPoder = 3f;
                break;


            case "neutral":

                efectoVisual = "que no hay ningun cambio";
                multiplicadorPoder = 1f;
                break;

        }

       
        print("El climabicho esta " + emocionActual + " (ves " + efectoVisual + ") " + "Poder actual: x" + multiplicadorPoder);
       return emocionActual;
      


    }



}
