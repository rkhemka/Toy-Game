using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour {

	public void StartGameButton(string newGameLevel){
		SceneManager.LoadScene (newGameLevel);
	}
	public void ExitButton(string exit){
		Application.Quit ();
	}
}
