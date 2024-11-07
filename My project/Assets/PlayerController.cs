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
        
    }

    public void SetHealthPoint()
    {
        _playerView.SetHealthPoint(_model.CurHealth);
    }
    public void Move(Vector2 direction)
    {
        _playerView.Move(_model.Speed,direction);
    }
}
