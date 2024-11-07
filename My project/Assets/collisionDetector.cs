using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetector : MonoBehaviour 
{
    private PlayerModel _playerModel;
    private const int _damage=20;

    public void Construct(PlayerModel player)
    {
        _playerModel = player;  
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _playerModel.TakeDamage(_damage);
            Debug.Log("ну пизда тебе копчённый");
        }
    }

}
