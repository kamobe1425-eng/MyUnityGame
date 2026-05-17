using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ProcessCharaAnimEvent : MonoBehaviour
{
    private CharacterScript characterScript;
    [SerializeField]
    private CapsuleCollider capsuleCollider;
 
    private void Start() {
        characterScript = GetComponent<CharacterScript>();
    }
    void AttackStart() {
        capsuleCollider.enabled = true;
    }
 
    void AttackEnd() {
        capsuleCollider.enabled = false;
    }
 
    void StateEnd() {
        characterScript.SetState(CharacterScript.MyState.Normal);
    }
    public void EndDamage() {
        characterScript.SetState(CharacterScript.MyState.Normal);
    }
}