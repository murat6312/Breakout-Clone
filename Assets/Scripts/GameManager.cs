using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject playerPrefab;
    public Text scoreText;
    public Text ballText;
    public Text levelText;
    public GameObject panelMenu;
    public GameObject panelPlay;
    public GameObject panelLevelComplete;
    public GameObject panelGameOver;
    public enum State {MENU, INIT, PLAY, LEVELCOMPLETED, LOADLEVEL, GAMEOVER};

    State state;
    void Start()
    {
        
    }


    void Update()
    {
        switch(state){
            case State.MENU:
                break;
            case State.INIT:
                break;
            case State.PLAY:
                break;
            case State.LEVELCOMPLETED:
                break;
            case State.LOADLEVEL:
                break;
            case State.GAMEOVER:
                break;

        }
    }
    public void SwitchState (State newState)
    {
        EndState();
        BeginState(newState);
    }

    void BeginState(State newState){

        switch(newState){
            case State.MENU:
                break;
            case State.INIT:
                break;
            case State.PLAY:
                break;
            case State.LEVELCOMPLETED:
                break;
            case State.LOADLEVEL:
                break;
            case State.GAMEOVER:
                break;

        }
        
    }

     void EndState(){

        switch(state){
            case State.MENU:
                break;
            case State.INIT:
                break;
            case State.PLAY:
                break;
            case State.LEVELCOMPLETED:
                break;
            case State.LOADLEVEL:
                break;
            case State.GAMEOVER:
                break;

        }
    }
}
