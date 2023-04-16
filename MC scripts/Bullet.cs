using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Скрипт работы пули и её взаимодействия с окружением

public class Bullet : MonoBehaviour
{
    public PlayerData data;

    //Все необходимые переменные
    public float BulletVelocity = 60f;
    public Rigidbody2D rb; 
    public GameObject Player; //Это сделано для переключения состояния переключателей

    void Start()
    {
        rb.velocity = transform.right * BulletVelocity; //Придача пуле скорости
    }

    private void OnCollisionEnter2D(Collision2D collision) //Взаимодействие с переключателями
    {
        if(collision.gameObject.tag == "Switch")
        {
            Switches.State = !Switches.State;
            if(Switches.State == true)
            {
                Debug.Log("Состояние OFF");
            }
            else
            {
                Debug.Log("Состояние ON");
            }
        }
        Destroy(gameObject);
    }
}