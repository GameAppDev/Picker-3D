using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidBody;

    private float _horizontalValue;

    [SerializeField] private float speedForward, speedHorizontal;

    void Start()
    {
        InputManager.Instance.onHorizontalValueChanged += OnHorizontalValueChanged;
    }

    private void FixedUpdate()
    {
        ForwardMovement();

        HorizontalMovement();
    }

    private void ForwardMovement()
    {
        rigidBody.velocity = new Vector3(0, 0, speedForward);
    }

    private void HorizontalMovement()
    {
        rigidBody.velocity += new Vector3(_horizontalValue * speedHorizontal * Time.fixedDeltaTime, 0, 0);
    }

    private void OnHorizontalValueChanged(float hValue)
    {
        _horizontalValue = hValue;
    }
}
