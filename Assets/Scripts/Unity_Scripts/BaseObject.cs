using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseObject : MonoBehaviour
{
    private GameObject _gameObject;
    public GameObject GameObject
    {
        private set
        {
            _gameObject = gameObject;
        }
        get
        {
            return _gameObject;
        }
    }

    private Transform _transform;
    public Transform Transform
    {
        private set
        {
            _transform = transform;
        }
        get
        {
            return _transform;
        }
    }

    protected void Awake()
    {
        GameObject = gameObject;
        Debug.Log(GameObject.name);
        Transform = transform;
    }
}
