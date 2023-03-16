using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item_lista_usuario : MonoBehaviour
{
    
    
    public string nombre;
    public string email;
    
    void Start()
    {
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = nombre;
        transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = email;

        var button = GetComponent<Button>();
        button.onClick.AddListener(delegate { UIManager.instance.Actualizar_Info_Persona_Seleccionada(nombre, email); });
    }


}
