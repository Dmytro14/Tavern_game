using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    [Header("Sprite To Change")]
    public SpriteRenderer bodyPart;

    [Header("Sprite to Cycle Through")]
    public List<Sprite> outfits = new List<Sprite>();

    private int currentOutfit = 0;

    private void Start() {
        Rand();
    }
    public void Rand()
    {
        currentOutfit = Random.Range(0, outfits.Count - 1);
        bodyPart.sprite = outfits[currentOutfit];
    }
}
