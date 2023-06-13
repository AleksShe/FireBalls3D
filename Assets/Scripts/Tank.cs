using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bulletTemplate;
    [SerializeField] private float _delayBetweenShoots;

    private float _timeAfterShoot;
    private void Update()
    {
        _timeAfterShoot += Time.deltaTime;
        if (Input.GetMouseButton(0))
        {
            if(_timeAfterShoot > _delayBetweenShoots)
            {
                Shoot();
                _timeAfterShoot = 0;
            }
        }
    }
    private void Shoot()
    {
        Instantiate(_bulletTemplate,_shootPoint.position,Quaternion.identity);
    }
}
