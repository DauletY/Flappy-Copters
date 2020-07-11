using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour
{
    public int _count;
    public float _Ymin = -2f;
    public float _Ymax = 2f;
    public float _spawnXpos = 10f;
    public float _timeSceneLastSpawn;
    public float _spawnRate; // скорость появления
    
    public GameObject _pipe;
    private GameObject[] _pipes;
    private Vector2 _objectPosition = new Vector2(-12f,-25f);
    
    private int _currentCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        _pipes = new GameObject[_count];
        for(int i = 0; i < _count; i++) {
            _pipes[i] = Instantiate(_pipe, _objectPosition, Quaternion.identity );
            //Debug.Log(_pipes[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        _timeSceneLastSpawn += Time.deltaTime;
        //Debug.Log(_timeSceneLastSpawn);

        if (_timeSceneLastSpawn >= _spawnRate) {
            _timeSceneLastSpawn = 0;
            float _spawnYpos = Random.Range(_Ymin, _Ymax);
            _pipes[_currentCount].transform.position = new Vector2(_spawnXpos, _spawnYpos);
            _currentCount++;
            if(_currentCount >= _count) _currentCount = 0;
        }
    }
    
}
