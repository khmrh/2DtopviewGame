using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item", fileName = "Newitem")]

public class ItemSO : ScriptableObject
{

    [Header("score value")]

    public int point = 10;
    
}
