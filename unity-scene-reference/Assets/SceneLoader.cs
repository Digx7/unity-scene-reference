using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private List<SceneReference> scenesToLoad;

    private void Start()
    {
        SceneManager.LoadScene(scenesToLoad[0]);
    }
}
