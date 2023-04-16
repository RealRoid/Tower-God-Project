using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State1 : MonoBehaviour
{
    public GameObject collider;
    void Update()
    {
        if (Switches.State == false)
        {
            collider.SetActive(false);
            Debug.Log("Состояние ON");
        }
        else
        {
            collider.SetActive(true);
        }
    }
}
