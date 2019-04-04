﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Cell : MonoBehaviour
{
    [SerializeField] private TextMeshPro _symbol;
    [SerializeField] private Image _panel;

    public Color BackgroundColor
    {
        get => _panel.color;
        set
        {
            _panel.color = value;
        }
    }

    public string Text
    {
        get
        {
            return _symbol.text;
        } 
        set
        {
            _symbol.text = value;
        }
    }

    public Color Color
    {
        get
        {
            return _symbol.color;
        }
        set
        {
            _symbol.color = value;
        }
    }
}