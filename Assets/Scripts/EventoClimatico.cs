using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventoClimatico : MonoBehaviour

{


    //Atributes

    //Public
    public string tipoEvento;
    public Climabicho origen;


    //Private
    private float  duracion ;


public void GenerarEvento(Climabicho climabichoOrigen,string emocionActual)
    {
        origen = climabichoOrigen;
        switch (emocionActual)
        {

            case "feliz":

                tipoEvento = "arcoíris" ;
                duracion = 2f;
                break;

            case "triste":

                tipoEvento = "lluvia";
                duracion = 1.5f;
                break;


            case "enojado":

                tipoEvento = "tempestad eléctrica";
                duracion = 2.5f;
                break;


            case "neutral":

                tipoEvento = "nada";
                duracion = 0.5f;
                break;


        }

        print(origen.nombre + " ha generado: " + tipoEvento + " que durará " + duracion + " turno/s");



    }



}
