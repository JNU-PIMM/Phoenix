using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveToDeath : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite bsprite;
    public Sprite dsprite;

    int whichAvatarIsOn = 1;

    public bool Player_states;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = bsprite;
            Player_states = true;
        }
    }

    public void SwitchSprite()
    {
        if(spriteRenderer.sprite == bsprite)
        {
            spriteRenderer.sprite = dsprite;
            Player_states = false;
        }
        else
        {
            spriteRenderer.sprite = bsprite;
            Player_states = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchSprite();
        }
    }
}
