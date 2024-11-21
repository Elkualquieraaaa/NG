using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chameleon_run : StateMachineBehaviour
{
    Chameleonmovement Chameleonmovement;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Chameleonmovement = animator.GetComponent<Chameleonmovement>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Chameleonmovement.transform.position.x > Chameleonmovement.objetive.transform.position.x)
        {
            Chameleonmovement.transform.rotation = Quaternion.Euler(0, 0, 0);
            Chameleonmovement.rigid.velocity = new Vector2(Chameleonmovement.velocitym, Chameleonmovement.rigid.velocity.y);
        }
        if (Chameleonmovement.transform.position.x < Chameleonmovement.objetive.transform.position.x)
        {
            Chameleonmovement.transform.rotation = Quaternion.Euler(0, 180, 0);
            Chameleonmovement.rigid.velocity = new Vector2(Chameleonmovement.velocitym*-1, Chameleonmovement.rigid.velocity.y);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Chameleonmovement.rigid.velocity = new Vector2(0, Chameleonmovement.rigid.velocity.y);
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
