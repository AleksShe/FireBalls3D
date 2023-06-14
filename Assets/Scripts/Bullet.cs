using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _bounceForce;
    [SerializeField] private float _bounceRadius;
    private Vector3 _moveDirection;
    private void Start()
    {
        _moveDirection = Vector3.forward;
    }
    private void Update()
    {
        transform.Translate(_moveDirection *_speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider obj)
    {
        if(obj.TryGetComponent(out Block block))
        {
            block.Break();
            Destroy(gameObject);
        }
        if(obj.TryGetComponent(out ObstacleElement obstacleElement)) 
        {
            Bounce();
        }
    }
    private void Bounce()
    {
        _moveDirection = Vector3.back + Vector3.up;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.AddExplosionForce(_bounceForce, transform.position + new Vector3(0, -1, 1), _bounceRadius);
    }
}
