using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
   public Button button;
	public Text buttonText;
	
private GameController gc;


	public void SetGameControllerReference(GameController controller){
gc = controller;
}

	public void SetSpace(){
	buttonText.text = gc.GetladoJogador();
button.interactable =false;
gc.FimJogada();

}
}
