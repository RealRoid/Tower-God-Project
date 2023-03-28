using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Что же это? Неужели переменные?
    public float BulletVelocity = 40f;
    public Rigidbody2D rb; 
    public GameObject Player;
    public bool SwitchState = true; //Это сделано для переключения состояния переключателей

    void Start()
    {
        rb.velocity = transform.right * BulletVelocity; //Придача пуле скорости
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Switch")
        {
            SwitchState = !SwitchState;
            Debug.Log("Переключатель сработал");
        }
        Destroy(gameObject);
    }
}