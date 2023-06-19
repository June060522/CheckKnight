using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    [SerializeField] GameObject Minimap;
    [SerializeField] GameObject Minimap2;
    [SerializeField] AudioClip board;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            EffectAudio.Instance.ListenEff(board);
            if(Minimap.activeSelf)
            {
                Minimap2.SetActive(false);
                Minimap.SetActive(false);
            }
            else
            {
                Minimap.SetActive(true);
                Minimap2.SetActive(true);
            }
        }
    }
}
