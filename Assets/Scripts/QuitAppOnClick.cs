﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitAppOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
