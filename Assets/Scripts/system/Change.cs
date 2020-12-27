using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour
{
    public Button button;
    public enum ChangeType
    {
        revive,
        death,
    }
    public ChangeType currentType;
    // Start is called before the first frame update
    void Start()
    {
        currentType = ChangeType.revive;
        button.image.color = new Color(255, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickButton()
    {
        if (currentType == ChangeType.revive)
        {
            currentType = ChangeType.death;
            button.image.color = new Color(0, 0, 255);
        }
        else
        { currentType = ChangeType.revive;
            button.image.color = new Color(255, 0, 0);
        }
    }
}
