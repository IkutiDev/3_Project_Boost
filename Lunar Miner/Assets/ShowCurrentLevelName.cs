using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShowCurrentLevelName : MonoBehaviour
{
    [SerializeField] private Text levelNameText;
    [SerializeField] private LevelNames levelNames;
    void Start()
    {
        levelNameText.text = levelNames.GetLevelName(SceneManager.GetActiveScene().buildIndex-2);
    }

}
