using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Sceneloading : MonoBehaviour
{
    [Header("Scena")]
    [SerializeField] private Object scena;

    public void LoadScene()
    {
        if (scena != null)
        {
            SceneManager.LoadScene(scena.name);
        }
        else
        {
            Debug.LogError(message: "Scena nieprzypisana");
        }
    }
}


       