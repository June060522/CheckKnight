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
    }
}
