using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [Header("Sprite To Change")]
    public List<SpriteRenderer> spriteRenderers = new List<SpriteRenderer>();

    [Header("Sprite to Cycle Through")]
    public List<Color> options = new List<Color>();


    private int currentOption = 0;
    
    public void NextColor()
    {
        currentOption++;
        if(currentOption >= options.Count)
        {
            currentOption = 0;
        }
        foreach (var item in spriteRenderers)
        {
            item.color = options[currentOption];
        }
    }
    public void PreviousColor()
    {
        currentOption--;
        if(currentOption <= 0)
        {
            currentOption = options.Count - 1;
        }
        foreach (var item in spriteRenderers)
        {
            item.color = options[currentOption];
        }
    }
    public void RandColor()
    {
        currentOption = Random.Range(0, options.Count - 1);
        foreach (var item in spriteRenderers)
        {
            item.color = options[currentOption];
        }
    }
}
