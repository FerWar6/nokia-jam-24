using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public bool isHovering = false;
    public Sprite baseSprite;
    public Sprite hoverSprite;

    private SpriteRenderer buttonSprite;
    private void Start()
    {
        buttonSprite = GetComponent<SpriteRenderer>();
        buttonSprite.sprite = baseSprite;
    }
    private void Update()
    {
        if (isHovering)
        {
            buttonSprite.sprite = hoverSprite;
        }
        else
        {
            buttonSprite.sprite = baseSprite;
        }
    }
}
