using UnityEngine;

public class PlayerBullet : Bullet
{
    private void Update()
    {
        MoveRight();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out EnemyPistol enemyPistol))
        {
            Destroy(enemyPistol.gameObject);
        }

        Destroy(gameObject);
    }
}
