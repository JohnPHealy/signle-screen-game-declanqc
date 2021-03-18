

using Cinemachine;
using UnityEngine;


public class BulletMovement : MonoBehaviour
{
    public GameObject bullet;
    public Rigidbody2D brb;
    public float speed = 20f;
    public GameObject player;
    void Update()
    {
        brb.velocity = transform.right * speed;
    }
    
}
