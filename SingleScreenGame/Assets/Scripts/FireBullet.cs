using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;


public class FireBullet : MonoBehaviour

{
    public GameObject bullet;
    public Sprite playerSprite;
    public void Shoot()

    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
