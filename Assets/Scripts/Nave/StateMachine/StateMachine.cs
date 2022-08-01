using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum States
    {
        Idle,
        Runnig,
        Dead,
    }
    public Dictionary<States, StateBase> dictionaryState;

    private StateBase _CurrentState;
    public Player player;
    public float timeToStartGame = 1f;

    private void Awake()
    {
        dictionaryState = new Dictionary<States, StateBase>();
        dictionaryState.Add(States.Idle, new StateBase());
        dictionaryState.Add(States.Runnig, new StateRunning());
        dictionaryState.Add(States.Dead, new StateBase());

        SwitchState(States.Idle);

        Invoke(nameof(StartGame), timeToStartGame);
    }

    private void StartGame()
    {
        SwitchState(States.Runnig);
    }

    private void SwitchState(States states)
    {
        if (_CurrentState != null) _CurrentState.onStateExit();

        _CurrentState = dictionaryState[states];

        _CurrentState.onStateEnter(player);
    }

    private void Update()
    {
        if (_CurrentState != null) _CurrentState.onStateStay();

        if(Input.GetKeyDown(KeyCode.O))
        {
            SwitchState(States.Dead);
        }
    }

}
