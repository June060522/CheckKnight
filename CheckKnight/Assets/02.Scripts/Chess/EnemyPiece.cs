using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPiece : Piece
{
    private void OnEnable()
    {
        x--;
        y--;
        Board.Instance.board[x,y] = (int)pieceType;
        rect = GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2((x * 95) - 333, (y * 95) - 330);
        Debug.Log(x * 95 + " : " + rect.position.x);
    }
}
