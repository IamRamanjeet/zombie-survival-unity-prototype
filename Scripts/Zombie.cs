using Unity.VisualScripting;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    private int health = 100;
    private Animator animator;
    [SerializeField] GameObject Player;
    private Transform playerref;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    playerref = Player.transform;   
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       float Distance = Vector3.Distance(playerref.position, transform.position);
       Vector3 direction = playerref.position - transform.position;
       float Angle = Vector3.Angle(direction, this.transform.forward);
        
        //zombie is idle
        if (Distance >50 || Angle >45)
        {
            animator.SetBool("walk", false);
            animator.SetBool("attack", false);
            animator.SetBool("dead", false);
            animator.SetBool("idle", true);
        }

        //walking to player
        if (Distance <50 && Angle <45)
      {
        animator.SetBool("walk", true);
            animator.SetBool("idle", false);
            animator.SetBool("attack", false);
            animator.SetBool("isdead", false);
            this.transform.LookAt(new Vector3(playerref.position.x, this.transform.position.y, playerref.position.z));
        animator.SetBool("Idle", false);
        }
        //attacking player
        if (Distance <3 && Angle <45)
        {
            animator.SetBool("attack", true);
            animator.SetBool("walk", false);
            animator.SetBool("idle", false);
            animator.SetBool("isdead", false);
        }
    }
}
