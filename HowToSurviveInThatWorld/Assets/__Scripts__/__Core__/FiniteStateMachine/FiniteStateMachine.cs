
using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Collider))]
public class FiniteStateMachine : MonoBehaviour
{
    #region Fields

    private readonly Dictionary<Type, Component> _cachedComponents = new();

    #endregion



    #region Unity Behavior

    private void Awake()
    {
        
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    #endregion



    #region Utils

    public new bool TryGetComponent<T>(out T component) where T : Component
    {
        var type = typeof(T);
        if (!_cachedComponents.TryGetValue(type, out var value))
        {
            if (base.TryGetComponent(out component))
            {
                _cachedComponents.Add(type, component);
            }

            return component != null;
        }

        component = value as T;
        return true;
    }

    public new T GetComponent<T>() where T : Component
    {
        return TryGetComponent(out T component)
            ? component
            : throw new InvalidOperationException($"{typeof(T).Name} not found in {name}");
    }

    #endregion
}
