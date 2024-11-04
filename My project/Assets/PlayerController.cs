using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController
{
    private readonly PlayerView _playerView;
    private readonly PlayerModel _model;
    
    public PlayerController(PlayerModel model,PlayerView view)
    {
        _model = model;
        _playerView = view;
        _model.OnHealthChange += SetHealthPoint;
        _model.OnPlayerDead += _playerView.Death;
    }

    private void SetHealthPoint()
    {
        _playerView.SetHealthPoint(_model.CurHealth);
    }

    private void TakeDamage(int damage)
    {
        _model.TakeDamage(damage);
    }
}
