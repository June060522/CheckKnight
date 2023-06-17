using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPiece : Piece
{
    private void Awake()
    {
        x--;
        y--;
    }
    private void OnEnable()
    {
        Board.Instance.board[x,y] = (int)pieceType;
        rect = GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2((x * 95) - 333, (y * 95) - 330);
    }

    private void Update()
    {
        if(BlackKing.Instance.x == x && BlackKing.Instance.y ==y)
        {
            Destroy(gameObject);
        }
    }
}
