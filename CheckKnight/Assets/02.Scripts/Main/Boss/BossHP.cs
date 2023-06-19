using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHP : MonoBehaviour
{
    [SerializeField]public float hp;
    public float maxhp;
    [SerializeField] Slider slider;

    private void Awake()
    {
        maxhp = hp;
    }
    private void Update()
    {
        if(hp <= 0)
        {
            GameStart.instance.End();
            Destroy(transform.parent.gameObject);
        }

        slider.value = 1 - (hp / maxhp);
    }
}
