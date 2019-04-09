﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : Creature
{
    private char[] _openedVerticalStates = { 'u', 'n' };
    private char[] _openedHorizontalStates = { ')', '(' };
    private char _verticalAnimClosed = 'o';
    private char _horizontalAnimClosed = 'O';
    private bool _lastStateWasClosed = true;

    public Pacman(int x, int y, int xDir, int yDir, Color color) : base(x, y, xDir, yDir, color)
    {

    }

    public override void Move()
    {
        base.Move();
        Animation();
    }

    public override char GetSkin()
    {
        if(_lastStateWasClosed)
            return YDir != 0 ? _openedVerticalStates[YDir < 0 ? 0 : 1] : _openedHorizontalStates[XDir < 0 ? 0 : 1];           
        else
            return YDir != 0 ? _verticalAnimClosed : _horizontalAnimClosed;
    }

    private void Animation()
    {
        _lastStateWasClosed = !_lastStateWasClosed;
    }
}
