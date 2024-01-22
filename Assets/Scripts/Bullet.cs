using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _secondsBeforeDestroy = 1.5f;

    public void DestroyAfterSeconds()
    {
        Destroy(gameObject, _secondsBeforeDestroy);
    }

    protected void MoveRight()
    {
        transform.Translate(transform.right * _speed * Time.deltaTime, Space.World);
    }

    protected void MoveLeft()
    {
        transform.Translate(-transform.right * _speed * Time.deltaTime, Space.World);
    }
}
