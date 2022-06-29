using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMaker : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject BulletSpawnPoint;
    public GameObject player;

    GameObject clonBala;
    public bool bulletFlying;
    Vector3 BalaRotation;
    public int VelocidadBala;

    void Start()
    {

    }

    void Update()
    {
        BalaRotation = BulletSpawnPoint.transform.eulerAngles;
        if (Input.GetKeyDown (KeyCode.Mouse0))
        {
            
            clonBala = Instantiate(bulletPrefab);
            clonBala.transform.position = BulletSpawnPoint.transform.position;
            clonBala.transform.eulerAngles = BalaRotation;
            clonBala.GetComponent<Rigidbody>().AddForce(player.transform.forward * VelocidadBala);
            Destroy(clonBala, 3);
            bulletFlying = true;
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            for (int i = 0; i < 3 ; i++)
            {
            clonBala = Instantiate(bulletPrefab);
            clonBala.transform.position = BulletSpawnPoint.transform.position;
            clonBala.transform.eulerAngles = BalaRotation;
            clonBala.GetComponent<Rigidbody>().AddForce(player.transform.forward * VelocidadBala);
            Destroy(clonBala, 3);
            bulletFlying = true;
            }
        }
    }
}   