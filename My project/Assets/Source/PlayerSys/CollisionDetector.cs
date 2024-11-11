
using UnityEngine;

namespace PlayerSys
{
    public class CollisionDetector : MonoBehaviour 
    {
        private PlayerModel _playerModel;
        private const int _damage=20;

        public void Construct(PlayerModel player)
        {
            _playerModel = player;  
        }
        private void OnTriggerEnter2D (Collider2D collision)
        {
            if (collision.gameObject.layer==LayerMask.NameToLayer("Enemy"))
            {
                _playerModel.TakeDamage(_damage);
                Debug.Log("ну пизда тебе копчённый");
            }
        }

    }
}
