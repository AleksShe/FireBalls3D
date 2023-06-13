using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private float _towerSize;
    [SerializeField] private Transform _buildPoint;
    [SerializeField] private Block _block;

    private List<Block> _blocks = new List<Block>();
    private void Start()
    {
        Build();
    }
    public List<Block> Build()
    {
        Transform currentPoint = _buildPoint;
        for (int i = 0; i < _towerSize; i++)
        {
            Block newBlock = BuildBlock(currentPoint);
            _blocks.Add(newBlock);
            currentPoint = newBlock.transform;
        }
        return _blocks;
    }
    private Block BuildBlock(Transform currentBuildPoint)
    {
       return Instantiate(_block, GetBuildPoint(currentBuildPoint), Quaternion.Euler(-90,0,0));
    }
    private Vector3 GetBuildPoint(Transform currentSegment)
    {
        return new Vector3(_buildPoint.position.x , currentSegment.position.y + 0.315f, _buildPoint.position.z);
    }
}
