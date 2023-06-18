using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackKing : MonoBehaviour
{
    public static BlackKing Instance;

    [SerializeField] private int xIndex = 3;
    [SerializeField] private int yIndex = 0;
    [SerializeField] private GameObject player;
    public int x => xIndex;
    public int y => yIndex;

    RectTransform rect;
    int blocksize = 95;

    bool isAlive = true;
    private void Awake()
    {
        Instance = this;
        rect = GetComponent<RectTransform>();
    }

    private void OnEnable()
    {
        rect.anchoredPosition = new Vector2((xIndex * 95) - 333, (yIndex * 95) - 330);
    }

    public void MoveUp()
    {
        rect.position = new Vector2(rect.position.x, rect.position.y + blocksize);
        yIndex++;
    }
    public void MoveDown()
    {
        rect.position = new Vector2(rect.position.x, rect.position.y - blocksize);
        yIndex--;
    }
    public void MoveRight()
    {
        rect.position = new Vector2(rect.position.x + blocksize, rect.position.y);
        xIndex++;
    }
    public void MoveLeft()
    {
        rect.position = new Vector2(rect.position.x - blocksize, rect.position.y);
        xIndex--;
    }

    public void GameOver()
    {
        PlayButtonManager.Instance.ClickQuit();
    }
}
