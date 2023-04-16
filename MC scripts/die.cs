using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class die : MonoBehaviour //незаконченный скрипт для смерти персонажа
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hazards")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Switches.State = true;
            Debug.Log("Bruh");
        }
    }
}