using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float _duration;
    private void Start()
    {
        transform.DORotate(new Vector3(0, 360, 0), _duration,RotateMode.FastBeyond360).SetLoops(-1,LoopType.Yoyo);
    }
}
