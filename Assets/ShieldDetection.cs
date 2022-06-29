using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldDetection : MonoBehaviour
{
    public GameObject Bala;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ammo")
        {
            Destroy(Bala);
        }
    }
}
