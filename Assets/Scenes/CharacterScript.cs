using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public enum MyState {
        Normal,
        Damage,
        Attack
    };
         MyState state;
         Animator animator;
    // Start is called before the first frame update
    void Start()
    {
            animator = GetComponentInChildren<Animator>(); 
        
        state = MyState.Normal;
    }
        void Update() {
            Debug.Log(state);
            
        if (state == MyState.Normal) {
    
                var input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
    
                if (input.magnitude > 0f) {
                    animator.SetFloat("Speed", input.magnitude);
                    transform.LookAt(transform.position + input);
                } else {
                    animator.SetFloat("Speed", 0f);
                }
                if(Input.GetButtonDown("Fire1")) {
                    SetState(MyState.Attack);
                    Debug.Log("Fire1");
                }
        }
    }
 
    public void SetState(MyState tempState) {
        if (tempState == MyState.Normal) {
            state = MyState.Normal;
            Debug.Log("Normal");
            }
            else if (tempState == MyState.Attack) {
            state = MyState.Attack;
            Debug.Log("animation start");
            animator.SetTrigger("kick");
            SetState(MyState.Normal);
            }
        }

        public void Hit()
        {
            Debug.Log("Hit!");
        }
        public void EndAttack()
    {
    SetState(MyState.Normal);
    }
}
