using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsChanger : MonoBehaviour
{
    [Header("Sprite To Change")]
    public List<SpriteRenderer> spriteRenderers = new List<SpriteRenderer>();

    [Header("Sprite to Cycle Through")]
    public List<Color> colors = new List<Color>();


    private int currentColor = 0;

    private void Start() {
        RandColor();
    }
    public void RandColor()
    {
        currentColor = Random.Range(0, colors.Count - 1);
        foreach (var item in spriteRenderers)
        {
            item.color = colors[currentColor];
        }
    }
}
