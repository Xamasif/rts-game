using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuNavigator : MonoBehaviour {

	// Change between menu screens
    public void LoadScene(string name) {
        Debug.Log("Loading new Scene");
        SceneManager.LoadScene(name);
	}

}
