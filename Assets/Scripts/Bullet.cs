using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _moveDirection;
    private void Start()
    {
        _moveDirection = Vector3.forward;
    }
    private void Update()
    {
        transform.Translate(_moveDirection *_speed * Time.deltaTime);
    }
}
