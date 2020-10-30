using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interfaz : MonoBehaviour
{
    public static Interfaz interfaz;
    public TextMeshProUGUI tiempoText;
    public float tiempo = 20;
    public GameObject pregunta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        tiempoText.text = "" + tiempo.ToString("f0");

        if (tiempoText.text == "0".ToString())
        {
            tiempo = 0;
            tiempoText.text = "" + tiempo.ToString("0");
        }
    }
 
}
