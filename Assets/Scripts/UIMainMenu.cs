using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainMenu : MonoBehaviour
{
	//Play Button - Game Start 

   
   public void StartGame ()
   {
	    Debug.Log("Play");
        SceneManager.LoadScene("Map", LoadSceneMode.Single); 
   }
   

   //Exit Button - End Game

   public void QuitGame ()
   {
		Debug.Log("Quit");
   	   Application.Quit();
   }

}