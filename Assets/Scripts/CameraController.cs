using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    [SerializeField] private EnemyPistol _enemyPistol;

    private Camera _camera;

    private void Awake()
    {
        _camera = GetComponent<Camera>();
    }

    public bool IsEnemyPistolInCameraView()
    {
        Vector3 viewportPoint = _camera.WorldToViewportPoint(_enemyPistol.transform.position);

        return viewportPoint.x >= 0.5f && viewportPoint.x <= 1;
    }
}
