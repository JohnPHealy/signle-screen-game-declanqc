using UnityEngine;


public class BulletMovement2 : MonoBehaviour
{
    public GameObject bullet;
    void Update()
    {
        transform.position += Vector3.left * (Time.deltaTime * 15);
    }
}