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

            case "Ex�t":
                Application.Quit();
                Debug.Log("Oyun kapat�ld�.");
                break;

            default:
                Debug.LogWarning("Tan�nmayan buton: " + buttonName);
                break;
        }
    }
}

