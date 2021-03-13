using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
   [SerializeField] private Collider2D playerCheck;
   [SerializeField] private LayerMask playerLayers;

   private void Update()
   {
      if (playerCheck.IsTouchingLayers((int) playerLayers))
      {
         Destroy(gameObject);
      }
   }

   private void OnCollisionEnter2D(Collision2D other)
   {
      if (other.gameObject.tag == "Player")
      {
         Destroy(other.gameObject);
      }
   }
}
