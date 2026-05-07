using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climabicho : MonoBehaviour
{


    //Atributes

    //Public
    public string nombre;
    public EstadoEmocional estado;
    public EventoClimatico evento;

    public bool activarPoder=false;
    //Private
    private float energia = 100f;





    
    void Start()
    {
        activarPoder = false;
 
    }

    
    void Update()
    {

        if (activarPoder)
        {

            usarPoder();
            activarPoder = false;

        }


    }

    void usarPoder ()
    {
        if(energia>=20f)
        {

            string emocionActual = estado.estadoActual();

            evento.GenerarEvento(this, emocionActual);

            energia -= 20f;

            print("Energía del climabicho: " + energia);

        }

        else
        {
            print("El climabicho está cansado");
        }




    }





}
