using System.Collections;
using UnityEngine;

[RequireComponent(typeof(PistolAnimation))]
public abstract class Pistol : MonoBehaviour
{
    [SerializeField] protected Transform ShootPoint;
    [SerializeField] protected float Delay;

    protected PistolAnimation _pistolAnimation;
    protected bool CanShoot = true;
    private Coroutine _shotDelayJob;

    private void Start()
    {
        _pistolAnimation = GetComponent<PistolAnimation>();
    }

    private void Update()
    {
        Shoot();
    }

    protected virtual void Shoot()
    {
        StopShotDelayCoroutine();
        _shotDelayJob = StartCoroutine(ShotDelay());

        CanShoot = false;
    }

    private IEnumerator ShotDelay()
    {
        var waitForSeconds = new WaitForSeconds(Delay);

        while (enabled)
        {
            yield return waitForSeconds;
            CanShoot = true;
        }
    }

    private void StopShotDelayCoroutine()
    {
        if (_shotDelayJob != null)
        {
            StopCoroutine(_shotDelayJob);
        }
    }
}
