using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using UnityEngine;
using UnityEngine.InputSystem;

public class RepasoProg : MonoBehaviour
{
    PlayerInput playerInput;
    public int contadorSalto;
    public List<float> instanteDeTiempo;

    void Start()
    {
        // Hello world
        Debug.Log("Hello world");

        playerInput = GetComponent<PlayerInput>();

        if (playerInput == null)
        {
            Debug.Log("No tiene componente PlayerInput");
        }

        contadorSalto = 0;
        instanteDeTiempo = new List<float>();
    }

    void Update()
    {
        // Detecta cuando se pulsa espacio (Jump)
        if (playerInput.actions["Jump"].WasPerformedThisFrame())
        {
            // Mensaje al pulsar
            Debug.Log("Jump pressed");

            // Contador de pulsaciones
            contadorSalto++;
            Mostrar("Pulsaciones: " + contadorSalto);

            // Guarda el instante temporal exacto
            instanteDeTiempo.Add(Time.time);

            // Muestra los tiempos guardados
            MostrarTiempos(instanteDeTiempo);
        }
    }

    // Método que muestra un texto recibido por parámetro
    public void Mostrar(string txt)
    {
        Debug.Log(txt);
    }

    // Método que muestra los instantes en formato T0, T1...
    public void MostrarTiempos(List<float> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            Debug.Log("T" + i + ": " + lista[i].ToString("F2") + "s");
        }
    }
}


//una variable que es de clase PlayerInput que tiene: atributos, metodos