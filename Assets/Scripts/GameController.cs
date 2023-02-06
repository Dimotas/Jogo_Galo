using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public Text[] buttonList;
private string ladoJogador;
public GameObject gameOverPanel;
public Text gameOverText;
private int mover;
public GameObject restartButton;



private void Awake(){
gameOverPanel.SetActive(false);
	SetGameControllerReferenceOnButtons();
ladoJogador = "X";
        mover = 0;
}

void SetGameControllerReferenceOnButtons(){
	for(int i = 0 ; i< buttonList.Length; i++){
	buttonList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);
}
}



  
public string GetladoJogador(){
	return ladoJogador;	
}

public void FimJogada(){
        mover++;
if(buttonList[0].text == ladoJogador && buttonList[1].text == ladoJogador && buttonList[2].text == ladoJogador ){
            mover = 0;
GameOver();

}
if(buttonList[3].text == ladoJogador && buttonList[4].text == ladoJogador && buttonList[5].text == ladoJogador ){
            mover = 0;
GameOver();

}
if(buttonList[6].text == ladoJogador && buttonList[7].text == ladoJogador && buttonList[8].text == ladoJogador ){
            mover = 0;
GameOver();
}
if(buttonList[0].text == ladoJogador && buttonList[3].text == ladoJogador && buttonList[6].text == ladoJogador ){
            mover = 0;
GameOver();
}
if(buttonList[1].text == ladoJogador && buttonList[4].text == ladoJogador && buttonList[7].text == ladoJogador ){
            mover = 0;
GameOver();
}
if(buttonList[2].text == ladoJogador && buttonList[5].text == ladoJogador && buttonList[8].text == ladoJogador ){
            mover = 0;
GameOver();
}
 
if(buttonList[0].text == ladoJogador && buttonList[4].text == ladoJogador && buttonList[8].text == ladoJogador ){
            mover = 0;
GameOver();
}
if(buttonList[2].text == ladoJogador && buttonList[4].text == ladoJogador && buttonList[6].text == ladoJogador ){
GameOver();
}
if(mover >= 9){

SetGameOverText("EMPATE!");
}
MudarLado();
}


void MudarLado(){
	ladoJogador = (ladoJogador=="X"? "O" : "X"); 
}


    void GameOver()
    {
	  SetBoardInteractable(false);

SetGameOverText(ladoJogador + " VENCEU!");   
    }

void SetGameOverText(string value){
gameOverPanel.SetActive(true);
gameOverText.text=value;
}

	public void RestartGame(){
		ladoJogador="X";
		mover = 0;
		gameOverPanel.SetActive(false);
  		SetBoardInteractable(true);
	for (int i=0; i<buttonList.Length; i++){
	
	buttonList[i].text = "";

		}   
	}

	void SetBoardInteractable(bool toggle){
	
	  for (int i=0; i<buttonList.Length; i++){
	buttonList[i].GetComponentInParent<Button>().interactable =toggle;
}
	}
}
