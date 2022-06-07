using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum WallState {opening, closing};

public class Wall : MonoBehaviour
{
    public GameObject target;
    Vector3 openPos;
    Vector3 closedPos;
    WallState state = WallState.opening;

     private void Awake() 
    { 
        openPos=this.transform.position;
        closedPos=target.transform.position;

        Debug.Log(openPos.ToString());
        Debug.Log(closedPos.ToString());
    }

    void Start()
    {
        
    }

    public void close(){
        state = WallState.closing;
    }

    public void open(){
        state = WallState.opening;
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name.ToLower() == "ball")
        {
            close();
        }
    }


    void Update()
    {
        float percent;
        switch(state){
            case WallState.opening:
                percent = openPos.y - this.transform.position.y;

                if(percent<1){
                    this.transform.position=Vector3.Slerp(openPos, closedPos, percent);
                }
                break;
            case WallState.closing:
                percent =  this.transform.position.y - closedPos.y;

                if(percent<1){
                    this.transform.position=Vector3.Slerp(closedPos, openPos, percent);
                }
                break;
        }

    }
}
