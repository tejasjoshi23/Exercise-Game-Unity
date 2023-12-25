using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class exerciseMotion : MonoBehaviour
{
    //bool isPressed = false;
    bool isWarmUp = false;
    bool isJump = false;
    Animator anim;
     
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // isWarmUp = Input.GetKey(KeyCode.S);
        // isJump = Input.GetKey(KeyCode.W);
        // anim.SetBool("warmUp", isWarmUp);
        // anim.SetBool("jump", isJump);
        
        
        // if(Input.GetKey(KeyCode.W)){
        //     Debug.Log("enter 1");
        //     isPressed =true;
        //     anim.SetBool("warmup", true);
        // }
        // else if(isPressed == false)
        // {
        //     Debug.Log("etner 34");
        //     anim.SetBool("warmup", false);
        // }
    }
    public void CharWarmUp(){
        if(true){
             anim.SetBool("warmUp", true);
             Debug.Log("w key");
        }
        else{
             anim.SetBool("warmUp", false);
             Debug.Log("not w");
        }
        }
        public void CharJump(){
             if(true){
             anim.SetBool("jump", true);
             Debug.Log("J key");
        }
        else{
             anim.SetBool("jump", false);
             Debug.Log("not J");
        }
        }
}
