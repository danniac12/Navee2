using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacktoPool : MonoBehaviour
{
    public Transform safeBox;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rock"))
        {
            collision.transform.position = new Vector2(safeBox.position.x, safeBox.position.y);
            collision.gameObject.SetActive(false);
        }
        if (collision.CompareTag("Clock"))
        {
            collision.transform.position = new Vector2(safeBox.position.x, safeBox.position.y);
            collision.gameObject.SetActive(false);
        }
    }
}
