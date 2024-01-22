using System;
using UnityEngine;

[RequireComponent(typeof(PistolMover))]
public class PlayerPistol : Pistol
{
    [SerializeField] private PlayerBullet _playerBulletPrefab;

    private PistolMover _pistolMover;

    public event Action GameOver;

    private void Awake()
    {
        _pistolMover = GetComponent<PistolMover>();
    }

    public void Reset()
    {
        _pistolMover.Reset();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameOver?.Invoke();
    }

    protected override void Shoot()
    {
        if (Input.GetMouseButtonDown(1) && CanShoot == true)
        {
            _pistolAnimation.SetShot();
            base.Shoot();
            PlayerBullet playerBullet = Instantiate(_playerBulletPrefab, ShootPoint.position, ShootPoint.rotation);
            playerBullet.DestroyAfterSeconds();
        }
    }
}
