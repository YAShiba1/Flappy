using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolTracker : MonoBehaviour
{
    [SerializeField] private Pistol _pistol;
    [SerializeField] private float _xOffset;

    private void Update()
    {
        var position = transform.position;
        position.x = _pistol.transform.position.x + _xOffset;
        transform.position = position;
    }
}
