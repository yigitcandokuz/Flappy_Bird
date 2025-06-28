using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void HandleButtonClick()
    {
        string buttonName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        switch (buttonName)
        {
            case "Start":
                SceneManager.LoadScene("SampleScene"); 
                break;

            case "Exýt":
                Application.Quit();
                Debug.Log("Oyun kapatýldý.");
                break;

            default:
                Debug.LogWarning("Tanýnmayan buton: " + buttonName);
                break;
        }
    }
}

