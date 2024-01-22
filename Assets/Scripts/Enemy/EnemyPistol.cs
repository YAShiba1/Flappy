using UnityEngine;

public class EnemyPistol : Pistol
{
    [SerializeField] private EnemyBullet _enemyBulletPrefab;

    protected override void Shoot()
    {
        if (CanShoot == true)
        {
            _pistolAnimation.SetShot();
            base.Shoot();
            EnemyBullet enemyBullet = Instantiate(_enemyBulletPrefab, ShootPoint.position, ShootPoint.rotation);
            enemyBullet.DestroyAfterSeconds();
        }
    }
}
