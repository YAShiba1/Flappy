using UnityEngine;

public class Remover : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out EnemyPistol enemyPistol))
        {
            Destroy(enemyPistol.gameObject);
        }
    }
}
