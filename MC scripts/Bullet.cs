using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//������ ������ ���� � � �������������� � ����������

public class Bullet : MonoBehaviour
{
    public PlayerData data;

    //��� ����������� ����������
    public float BulletVelocity = 60f;
    public Rigidbody2D rb; 
    public GameObject Player; //��� ������� ��� ������������ ��������� ��������������

    void Start()
    {
        rb.velocity = transform.right * BulletVelocity; //������� ���� ��������
    }

    private void OnCollisionEnter2D(Collision2D collision) //�������������� � ���������������
    {
        if(collision.gameObject.tag == "Switch")
        {
            Switches.State = !Switches.State;
            if(Switches.State == true)
            {
                Debug.Log("��������� OFF");
            }
            else
            {
                Debug.Log("��������� ON");
            }
        }
        Destroy(gameObject);
    }
}