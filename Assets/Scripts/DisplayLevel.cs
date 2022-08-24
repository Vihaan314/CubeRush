using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class DisplayLevel : MonoBehaviour
{
    public TextMeshProUGUI levelText;

    private static string GetSceneNameFromScenePath(string scenePath)
    {
        var sceneNameStart = scenePath.LastIndexOf("/", StringComparison.Ordinal) + 1;
        var sceneNameEnd = scenePath.LastIndexOf(".", StringComparison.Ordinal);
        var sceneNameLength = sceneNameEnd - sceneNameStart;
        return scenePath.Substring(sceneNameStart, sceneNameLength);
    }
    void Start()
    {
        var nextLevel = GetSceneNameFromScenePath(SceneUtility.GetScenePathByBuildIndex(SceneManager.GetActiveScene().buildIndex + 1));
        string nextLevelStr = nextLevel.ToString();
        Debug.Log(nextLevel);
        levelText.text = "Level " + nextLevelStr.Substring(nextLevelStr.Length - 1);
    }
}
