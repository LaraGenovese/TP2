using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraseñaCorrecta;
    string contraseñaUsuario;
    public Text ingresoUsuario;
    public Text textoMsj;
    public GameObject cartelMsj;

    void Start()
    {
        contraseñaCorrecta = "hola";
        cartelMsj.SetActive(false);
    }

    void Update()
    {
        
    }

    public void validarContraseña()
    {
        contraseñaUsuario = ingresoUsuario.text;

        if(contraseñaCorrecta == contraseñaUsuario)
        {
            cartelMsj.SetActive(true);
            textoMsj.color = Color.blue;
            textoMsj.text = "Bienvenid@!";
            Debug.Log("Bienvenid@!");
        }
        else
        {
            textoMsj.text = "Contraseña INCORRECTA";
            cartelMsj.SetActive(true);
            Debug.Log("Constraseña incorrecta");
        }
    }
}
