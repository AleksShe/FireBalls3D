using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    [SerializeField] private ParticleSystem _destroyEffect;
    public event UnityAction<Block> BulletHit;
    public void Break()
    {
        BulletHit?.Invoke(this);
        ParticleSystemRenderer renderer = Instantiate(_destroyEffect, transform.position,_destroyEffect.transform.rotation ).GetComponent<ParticleSystemRenderer>();
        renderer.material.color = GetComponent<MeshRenderer>().material.color;

        Destroy(gameObject);
    }
}
