using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBase : MonoBehaviour
{
    public virtual void onStateEnter(object o = null)
    {
        Debug.Log("onStateEnter");
    }

    public virtual void onStateStay()
    {
        Debug.Log("onStateStay");
    }

    public virtual void onStateExit()
    {
        Debug.Log("onStateExit");
    }
}

public class StateRunning : StateBase
{
    public Player player;
    public override void onStateEnter(object o = null)
    {
        player = (Player)o;
        player.canMove = true;
        player.ChangeColor(Color.blue);

        base.onStateEnter(o);
    }

    public override void onStateExit()
    {
        player.canMove = false;
        player.ChangeColor(Color.magenta);
        base.onStateExit();
    }
}
