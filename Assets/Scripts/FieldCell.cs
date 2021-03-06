﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[Serializable]
public class FieldCell
{
    public Vector2Int pos;
    public TileBase tile;
    public Player tilePlayer;
    public bool isAvaiable = true;

    public FieldCell(TileBase tile,Vector2Int pos)
    {
        this.pos = pos;
        this.tile = tile;
    }

    public FieldCell(TileBase tile, Vector2Int pos, Player player)
    {
        this.pos = pos;
        this.tile = tile;
        tilePlayer = player;
    }
}
