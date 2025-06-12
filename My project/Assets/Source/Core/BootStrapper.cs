using PlayerSys;
using UnityEngine;
namespace Core
{
  public class BootStrapper : MonoBehaviour
  {
    [SerializeField] private CollisionDetector _collisionDetector;
    private PlayerModel _playerModel;
    [SerializeField] private PlayerView _playerView;
    private PlayerController _playerController;
    [SerializeField]private InputListener _inputListener;
    private const int _maxHealth = 100;
    private const float _speed = 20;
    private void Start()
    {
      _playerModel = new PlayerModel(_maxHealth,_speed);
      Debug.Log(_playerModel);
      _playerController = new PlayerController(_playerModel,_playerView);
      Debug.Log(_playerController); 
      _inputListener.Construct(_playerController);
      _playerController.SetHealthPoint();
      _collisionDetector.Construct(_playerModel);
    }
  }   
}
