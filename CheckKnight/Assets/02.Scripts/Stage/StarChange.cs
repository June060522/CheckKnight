using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarChange : MonoBehaviour
{
    [SerializeField] string index;
    [SerializeField] Image[] image;
    [SerializeField] Sprite a;

    private void Update()
    {
        if(PlayerPrefs.GetInt(index,0) == 1)
        {
            foreach(Image item in image)
            {
                item.sprite = a;
            }
        }
    }
}
