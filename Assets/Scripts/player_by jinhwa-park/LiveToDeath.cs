using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveToDeath : MonoBehaviour
{
    public Sprite bsprite; // 살아있는거
    public Sprite dsprite; // 죽은거
    
    public GameObject bAnim; // 살아있을때 animation
    public GameObject dAnim; // 죽었을때 animation

    int whichAvatarIsOn = 1;

    public bool player_states;

    // Start is called before the first frame update
  
    

    public void Switch()
    {
        if(player_states == true)
        {
            player_states = false;
            transform.gameObject.tag = "Untagged";

            bAnim.SetActive(true);
            dAnim.SetActive(false);
        }
        else
        {
            player_states = true;
            transform.gameObject.tag = "Player";

            bAnim.SetActive(false);
            dAnim.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Switch();
        }
    }
}
