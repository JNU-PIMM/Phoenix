using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveToDeath : MonoBehaviour
{
    public GameObject live, death;

    int whichAvatarIsOn = 1;


    // Start is called before the first frame update
    void Start()
    {
        live.gameObject.SetActive(true);
        death.gameObject.SetActive(false);
    }

    public void SwitchAvatar()
    {
//       switch (whi)
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
