using UnityEngine;
namespace PlayerSys
{
    public class PlayerController
    {
        private readonly PlayerView _playerView;
        private readonly PlayerModel _model;
        public PlayerController(PlayerModel model,PlayerView view)
        {
            _model = model;
            _playerView = view;
            _model.OnHealthChange += SetHealthPoint;
            _model.OnPlayerDead += Death;
        }
        public void SetHealthPoint()
        {
            _playerView.SetHealthPoint(_model.CurHealth);
        }
        public void Death()
        {
            _playerView.Death();
        }
        public void Move(Vector2 direction)
        {
            _playerView.Move(_model.Speed,direction);
        }
    }
}
