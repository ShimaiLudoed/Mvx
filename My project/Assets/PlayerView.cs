using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerView : MonoBehaviour
{
    [SerializeField] public TMP_Text playerHealth;
    [SerializeField] private Sprite playerAlive;
    [SerializeField] private Sprite playerDead;

    public void SetHealthPoint(int health)
    {
        playerHealth.text = $"Health {health}";
    }
}
