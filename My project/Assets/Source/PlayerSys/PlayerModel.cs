using System;
namespace PlayerSys
{
    public class PlayerModel
    {
        public int CurHealth { get; private set; } 
        public event Action OnHealthChange;
        public event Action OnPlayerDead;
        public float Speed {  get; private set; }
        public PlayerModel(int health, float speed)
        {
            CurHealth = health;
            Speed = speed;
        }
        public void TakeDamage(int damage)
        {
            CurHealth-=damage;
            OnHealthChange?.Invoke();
            if (CurHealth <= 0)
            {
                OnPlayerDead?.Invoke();
            }
        }
    }
}
