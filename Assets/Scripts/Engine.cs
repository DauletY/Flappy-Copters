
using UnityEngine;

public abstract class Engine : MonoBehaviour  
{
    public virtual void Start(){
        
    }
    public abstract  void  AudioPlayer(AudioSource source);
}