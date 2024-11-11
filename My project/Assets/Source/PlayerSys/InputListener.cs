using UnityEngine;

namespace PlayerSys
{
    public class InputListener : MonoBehaviour
    {
        private PlayerController _playerController;

        public void Construct(PlayerController player)
        {
            _playerController = player;
        }
        private void Update()
        {
            if ( _playerController != null )
            {
                float horizontal;
                horizontal=Input.GetAxis("Horizontal");
                float vertical;
                vertical = Input.GetAxis("Vertical");
                Vector2 vec = new Vector2(horizontal, vertical).normalized;
                _playerController.Move(vec);
            }
        }
    }
}
