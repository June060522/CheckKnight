using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    [Header("위치")]
    [SerializeField] protected int x;
    [SerializeField] protected int y;

    [Header("타입")]
    [SerializeField] protected EnemyTypes pieceType;
    
    
    protected RectTransform rect;
}
