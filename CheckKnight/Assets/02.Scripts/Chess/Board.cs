using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Board : MonoBehaviour
{
    public static Board Instance;
    public int[,] board = new int[8, 8];

    public int[] availableX;
    public int[] availableY;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
        {
            Debug.LogError($"{transform} : Board Instance is multiply!");
            Destroy(gameObject);
        }

        for (int i = 0; i < availableX.Length; i++)
        {
            CheckMark.Instance.InputRedZone(availableX[i], availableY[i]);
        }
    }

    private void Update()
    {
        LoadMap();
    }

    private void LoadMap()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (board[i, j] == 7)
                    board[i, j] = 0;
            }
        }

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                switch (board[i, j])
                {
                    case 1://폰일때
                        if (i - 1 >= 0 && j - 1 >= 0 && board[i - 1, j - 1] == 0)//왼쪽 아래
                            board[i - 1, j - 1] = 7;

                        if (i + 1 < 8 && j - 1 >= 0 && board[i + 1, j - 1] == 0)//오른쪽 아래
                            board[i + 1, j - 1] = 7;

                        break;

                    case 2://비숍일때
                        int saveIdxX = i;
                        int saveIdxY = j;
                        //오른쪽 위
                        while (++saveIdxX < 8 && ++saveIdxY < 8 && (board[saveIdxX, saveIdxY] == 0 || board[saveIdxX, saveIdxY] == 7))
                            board[saveIdxX, saveIdxY] = 7;

                        saveIdxX = i;
                        saveIdxY = j;
                        //왼쪽 위
                        while (--saveIdxX >= 0 && ++saveIdxY < 8 && (board[saveIdxX, saveIdxY] == 0 || board[saveIdxX, saveIdxY] == 7))
                            board[saveIdxX, saveIdxY] = 7;

                        saveIdxX = i;
                        saveIdxY = j;
                        //오른쪽 아래
                        while (++saveIdxX < 8 && --saveIdxY >= 0 && (board[saveIdxX, saveIdxY] == 0 || board[saveIdxX, saveIdxY] == 7))
                            board[saveIdxX, saveIdxY] = 7;

                        saveIdxX = i;
                        saveIdxY = j;
                        //왼쪽 아래
                        while (--saveIdxX >= 0 && --saveIdxY >= 0 && (board[saveIdxX, saveIdxY] == 0 || board[saveIdxX, saveIdxY] == 7))
                            board[saveIdxX, saveIdxY] = 7;

                        break;
                    case 3://나이트일때

                        if (i + 1 < 8 && j + 2 < 8 && board[i + 1, j + 2] == 0)
                            board[i + 1, j + 2] = 7;

                        if (i + 2 < 8 && j + 1 < 8 && board[i + 2, j + 1] == 0)
                            board[i + 2, j + 1] = 7;

                        if (i - 1 >= 0 && j - 2 >= 0 && board[i - 1, j - 2] == 0)
                            board[i - 1, j - 2] = 7;

                        if (i - 2 >= 0 && j - 1 >= 0 && board[i - 2, j - 1] == 0)
                            board[i - 2, j - 1] = 7;

                        if (i - 1 >= 0 && j + 2 < 8 && board[i - 1, j + 2] == 0)
                            board[i - 1, j + 2] = 7;

                        if (i - 2 >= 0 && j + 1 < 8 && board[i - 2, j + 1] == 0)
                            board[i - 2, j + 1] = 7;

                        if (i + 1 < 8 && j - 2 >= 0 && board[i + 1, j - 2] == 0)
                            board[i + 1, j - 2] = 7;

                        if (i + 2 < 8 && j - 1 < 8 && board[i + 2, j - 1] == 0)
                            board[i + 2, j - 1] = 7;

                        break;
                    case 4://룩일때
                        int IdxX = i;
                        int IdxY = j;
                        //오른쪽
                        while (++IdxX < 8 && (board[IdxX, IdxY] == 0 || board[IdxX, IdxY] == 7))
                            board[IdxX, IdxY] = 7;

                        IdxX = i;
                        IdxY = j;
                        //왼쪽
                        while (--IdxX >= 0 && (board[IdxX, IdxY] == 0 || board[IdxX, IdxY] == 7))
                            board[IdxX, IdxY] = 7;

                        IdxX = i;
                        IdxY = j;
                        //위
                        while (++IdxY < 8 && (board[IdxX, IdxY] == 0 || board[IdxX, IdxY] == 7))
                            board[IdxX, IdxY] = 7;

                        IdxX = i;
                        IdxY = j;
                        //아래
                        while (--IdxY >= 0 && (board[IdxX, IdxY] == 0 || board[IdxX, IdxY] == 7))
                            board[IdxX, IdxY] = 7;
                        break;
                    case 5://퀸일때
                        int qIdxX = i;
                        int qIdxY = j;

                        while (++qIdxX < 8 && ++qIdxY < 8 && (board[qIdxX, qIdxY] == 0 || board[qIdxX, qIdxY] == 7))
                            board[qIdxX, qIdxY] = 7;

                        qIdxX = i;
                        qIdxY = j;
                        //왼쪽 위
                        while (--qIdxX >= 0 && ++qIdxY < 8 && (board[qIdxX, qIdxY] == 0 || board[qIdxX, qIdxY] == 7))
                            board[qIdxX, qIdxY] = 7;

                        qIdxX = i;
                        qIdxY = j;
                        //오른쪽 아래
                        while (++qIdxX < 8 && --qIdxY >= 0 && (board[qIdxX, qIdxY] == 0 || board[qIdxX, qIdxY] == 7))
                            board[qIdxX, qIdxY] = 7;

                        qIdxX = i;
                        qIdxY = j;
                        //왼쪽 아래
                        while (--qIdxX >= 0 && --qIdxY >= 0 && (board[qIdxX, qIdxY] == 0 || board[qIdxX, qIdxY] == 7))
                            board[qIdxX, qIdxY] = 7;

                        qIdxX = i;
                        qIdxY = j;

                        while (++qIdxX < 8 && (board[qIdxX, qIdxY] == 0 || board[qIdxX, qIdxY] == 7))
                            board[qIdxX, qIdxY] = 7;

                        qIdxX = i;
                        qIdxY = j;
                        //왼쪽
                        while (--qIdxX >= 0 && (board[qIdxX, qIdxY] == 0 || board[qIdxX, qIdxY] == 7))
                            board[qIdxX, qIdxY] = 7;

                        qIdxX = i;
                        qIdxY = j;
                        //위
                        while (++qIdxY < 8 && (board[qIdxX, qIdxY] == 0 || board[qIdxX, qIdxY] == 7))
                            board[qIdxX, qIdxY] = 7;

                        qIdxX = i;
                        qIdxY = j;
                        //아래
                        while (--qIdxY >= 0 && (board[qIdxX, qIdxY] == 0 || board[qIdxX, qIdxY] == 7))
                            board[qIdxX, qIdxY] = 7;
                        break;
                    case 6: // 킹일때
                        if (i - 1 >= 0 && j - 1 >= 0 && board[i - 1, j - 1] == 0)//왼쪽 아래
                            board[i - 1, j - 1] = 7;

                        if (i + 1 < 8 && j - 1 >= 0 && board[i + 1, j - 1] == 0)//오른쪽 아래
                            board[i + 1, j - 1] = 7;

                        if (j - 1 >= 0 && board[i, j - 1] == 0)//아래쪽
                            board[i, j - 1] = 7;

                        if (i + 1 < 8 && board[i + 1, j] == 0)//오른쪽
                            board[i + 1, j] = 7;

                        if (i - 1 >= 0 && board[i - 1, j] == 0)//왼쪽
                            board[i - 1, j] = 7;

                        if (j + 1 < 8 && board[i, j + 1] == 0)//위쪽
                            board[i, j + 1] = 7;

                        if (i - 1 >= 0 && j + 1 < 8 && board[i - 1, j + 1] == 0)//왼쪽 위
                            board[i - 1, j + 1] = 7;

                        if (i + 1 < 8 && j + 1 < 8 && board[i + 1, j + 1] == 0)//오른쪽 위
                            board[i + 1, j + 1] = 7;

                        break;
                }
            }
        }

        for(int i = 0; i < availableX.Length; i++)
        {
            board[availableX[i],availableY[i]] = 0;
        }
        
        if (board[BlackKing.Instance.x, BlackKing.Instance.y] == 7)
        {
            HP.Instance.hp = 0;
        }
    }
}