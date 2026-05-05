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


    //Private
    private string[] tipo = { "Feliz", "Triste", "Enojado", "Neutral"};

    private float multiplicadorPoder;

   public void estadoActual()
    {
        int lista = Random.Range(0, tipo.Length);
        string emocion = tipo[lista];

        switch (emocion)
        {

            case "Feliz":

                efectoVisual = "una luz radiante";

              break;

            case "Triste":

                efectoVisual = "niebla azulada";

                break;

            case "Enojado":

                efectoVisual = "nubes negras";

                break;


            case "Neutral":

                efectoVisual = "que no hay ningun cambio";

                break;

        }

        print("El climabicho esta " + emocion + "(ves " + efectoVisual + ")");

       // Debug.Log("Emocion: " + emocion);
      // Debug.Log("Efecto visual: " + efectoVisual);



    }



}
