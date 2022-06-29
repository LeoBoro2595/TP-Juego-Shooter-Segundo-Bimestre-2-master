using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeteccionEnemigoMayor : MonoBehaviour
{
    public PlayerController Ctrl;
    public Text Kills;
    int i = 0;

    void Start()
    {
        Ctrl = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision enemigoMayor)
    {
        if (enemigoMayor.gameObject.tag == "Ammo")
        {
            i++;
            if (i == 10)
            {

                Ctrl.kills_i++;
                Destroy(gameObject);
                Debug.Log(Ctrl.kills_i);
                Kills.text = "Kills: " + Ctrl.kills_i;
            }
        }
    }
}
