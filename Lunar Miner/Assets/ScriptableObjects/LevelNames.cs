using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "LevelNames")]
public class LevelNames : ScriptableObject
{
    [SerializeField] private string[] levelNames;

    public string GetLevelName(int i)
    {
        return levelNames[i];
    }
}
