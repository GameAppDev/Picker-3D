using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    public UnityAction<float> onHorizontalValueChanged = delegate { };

    private float _horizontalValue;
    private float _mousePos;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    
    void Update()
    {
        _horizontalValue = Input.GetAxisRaw("Horizontal");

        onHorizontalValueChanged?.Invoke(_horizontalValue);
    }
}
