using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootStrapper : MonoBehaviour
{
    private PlayerModel _playerModel;
    private PlayerView _playerView;
    private PlayerController _playerController;
    private const int _maxHealth = 100;

    private void Start()
    {
        _playerModel = new PlayerModel(_maxHealth);
        _playerController = new PlayerController(_playerModel,_playerView);
    }
}
