﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Logics : MonoBehaviour
{
    public void ToggleEffect(Image image)
    {
        if (image)
        {
            if (image.color != Color.green)
                image.color = Color.green;
            else
                image.color = Color.white;
        }
    }
}
