using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contrasenia : MonoBehaviour
{
    public string contraseña;
    public InputField impContra;
    public void contra()
    {
        if (impContra.text == contraseña)
        {
            Debug.Log("¿Lo habéis conseguido? ¿1-2-3-4-5? ¡Es la misma contraseña que tengo en mis maletas!");
        }
        else
        {
            Debug.Log("¿¡¿1-2-3-4-5?!? ¡Ésa es la contraseña que un idiota pondría en sus maletas!");
        }
    }
}
