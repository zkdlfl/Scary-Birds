using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;

public class SlingShotArea : MonoBehaviour
{
    [SerializeField] private LayerMask _slingshotAreaMask;
    public bool IsWithinSlingShotArea()
    {
        UnityEngine.Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (Physics2D.OverlapPoint(worldPosition, _slingshotAreaMask))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
