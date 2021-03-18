using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;



public class FireBullet : MonoBehaviour

{
    public GameObject bullet;
    public void Shoot()
    {
        
            Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
