using System;
using TMPro;
using UnityEngine;
namespace PlayerSys
{
    public class PlayerView : MonoBehaviour
    {
        private Rigidbody2D rb;
        public TMP_Text playerHealth;
        public Transform playerTransform;
        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }
        public void SetHealthPoint(int health)
        {
            playerHealth.text = $"Health {health}";
        }
        public void Death()
        {
            Destroy(gameObject);
        }
        public void Move(float Speed, Vector2 direction)
        {
            Vector3 dir = new Vector3(direction.x, direction.y, 0);
            //transform.position += dir * Speed * Time.deltaTime;
            rb.linearVelocity = dir * Speed;
        }
    }
}
