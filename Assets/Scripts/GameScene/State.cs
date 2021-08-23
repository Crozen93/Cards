using UnityEngine;

public abstract class State : ScriptableObject
{
    //gameplay parametrs 
    public bool isFineshed { get; protected set; }
    [HideInInspector] public GameLogick gameLogick;

    public virtual void Init() { }
    public abstract void Run();

}