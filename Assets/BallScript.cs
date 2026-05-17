using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public enum BallState {
    freese,
    isKicked,
    isTaken
    }
    BallState state;
    // Start is called before the first frame update
    void Start()
    {
        state = BallState.freese;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        //　敵キャラクターの状態変更メソッド
    public void SetState(BallState tempState, Transform targetObj = null) {
        state = tempState;
        if (tempState == BallState.freese) {
        } else if (tempState == BallState.isKicked) {
        } else if (tempState == BallState.isTaken) {
        }
    }
}
