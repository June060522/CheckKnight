using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    [Header("��ġ")]
    [SerializeField] protected int x;
    [SerializeField] protected int y;

    [Header("Ÿ��")]
    [SerializeField] protected EnemyTypes pieceType;
    
    
    protected RectTransform rect;
}
