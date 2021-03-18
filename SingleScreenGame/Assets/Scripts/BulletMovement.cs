

using UnityEngine;


public class BulletMovement : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {
        transform.position += Vector3.right * (Time.deltaTime * 15);
    }
    
}
