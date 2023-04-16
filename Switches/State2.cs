using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State2 : MonoBehaviour
{
    public GameObject collider;
    void Update()
    {
        if (Switches.State == true)
        {
            collider.SetActive(false);
            Debug.Log("Состояние OFF");
        }
        else
        {
            collider.SetActive(true);
        }
    }
}
