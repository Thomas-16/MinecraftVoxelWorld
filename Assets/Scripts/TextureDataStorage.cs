using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureDataStorage : MonoBehaviour
{
    public float textureSizeX, textureSizeY;
    public List<TextureData> textureDataList;
}


[Serializable]
public class TextureData
{
    public BlockType blockType;
    public Vector2Int up, down, side;
    public bool isSolid = true;
    public bool generatesCollider = true;
}

