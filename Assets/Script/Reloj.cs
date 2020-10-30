using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reloj : MonoBehaviour
{
    Interfaz interfaz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AddTime();
            collision.gameObject.SetActive(false);
            
        }
    }

    void AddTime()
    {
        interfaz.tiempo = 20;
        interfaz.pregunta.SetActive(true);

    }
}
