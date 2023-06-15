using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackKing : MonoBehaviour
{
    [SerializeField] private int xIndex = 3;
    [SerializeField] private int yIndex = 0;

    RectTransform rect;
    int blocksize = 95;

    bool isAlive = true;
    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    private void OnEnable()
    {
        rect.anchoredPosition = new Vector2((xIndex * 95) - 333, (yIndex * 95) - 330);
    }

    private void MoveUp()
    {
        rect.position = new Vector2(rect.position.x, rect.position.y + blocksize);
        yIndex++;
    }
    private void MoveDown()
    {
        rect.position = new Vector2(rect.position.x, rect.position.y - blocksize);
        yIndex--;
    }
    private void MoveRight()
    {
        rect.position = new Vector2(rect.position.x + blocksize, rect.position.y);
        xIndex++;
    }
    private void MoveLeft()
    {
        rect.position = new Vector2(rect.position.x - blocksize, rect.position.y);
        xIndex--;
    }

    private void Die()
    {
        Debug.Log(Board.Instance.board[xIndex, yIndex]);
        if (Board.Instance.board[xIndex, yIndex] == 7)
        {
            StartCoroutine(IDie());
        }
    }

    IEnumerator IDie()
    {
        isAlive = false;
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
