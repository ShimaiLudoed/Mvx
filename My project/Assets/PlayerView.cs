using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerView : MonoBehaviour
{
     public TMP_Text playerHealth;
    [SerializeField] private Sprite playerAlive;
    [SerializeField] private Sprite playerDead;
     public Transform playerTransform;

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
        transform.position += dir * Speed * Time.deltaTime;
    }
}
