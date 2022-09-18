using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Back : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void backButtonClicked()
    {
        Application.LoadLevel("Main Menu");
    }
}
