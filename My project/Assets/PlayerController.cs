using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController
{
    private PlayerView _playerView;
    private PlayerModel _model;
    
    public void ShowHealthPoint()
    {
        _playerView.SetHealthPoint(_model.CurHealth);
    }
}
