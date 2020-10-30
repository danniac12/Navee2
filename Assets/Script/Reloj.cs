using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reloj : MonoBehaviour
{
    public Interfaz interfaz;
    public Transform safeBox;
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
     
        interfaz.pregunta.SetActive(true);
        gameObject.transform.position = new Vector2(safeBox.position.x, safeBox.position.y);
        gameObject.SetActive(false);
    }
}
