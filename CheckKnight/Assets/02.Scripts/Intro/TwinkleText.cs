using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TwinkleText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshPro;

    float alp = 1f;
    private void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        StartCoroutine(Twinkle());
    }

    IEnumerator Twinkle()
    {
        while (alp > 0.3f)
        {
            textMeshPro.color = new Color(1,1,1,alp);
            alp -= 0.1f;
            yield return new WaitForSeconds(0.1f);
        }
        yield return StartCoroutine(Twink());
    }

    IEnumerator Twink()
    {
        while (alp < 1f)
        {
            textMeshPro.color = new Color(1, 1, 1, alp);
            alp += 0.1f;
            yield return new WaitForSeconds(0.1f);
        }
        yield return StartCoroutine(Twinkle());
    }
}
