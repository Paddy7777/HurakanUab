using UnityEngine;
using System.Collections;

public class AnimController : MonoBehaviour {


    private Animator anim;
    public float speed;
    public Rigidbody rb;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();

        anim = GetComponent<Animator>();

        anim.SetBool("spin", false);
        anim.SetBool("spins", false);
        anim.SetBool("backs", false);

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Keypad1))
            anim.SetBool("spin", true);

        if (Input.GetKeyUp(KeyCode.Keypad1))
            anim.SetBool("spin", false);

        if (Input.GetKeyDown(KeyCode.Keypad2))
            anim.SetBool("spins", true);

        if (Input.GetKeyUp(KeyCode.Keypad2))
            anim.SetBool("spins", false);

        if (Input.GetKeyDown(KeyCode.Keypad3))
            anim.SetBool("backs", true);

        if (Input.GetKeyUp(KeyCode.Keypad3))
            anim.SetBool("backs", false);

        
        if (Input.GetKeyDown(KeyCode.LeftShift))
            rb.AddForce(0, 0, speed, ForceMode.Impulse);

        if (Input.GetKeyUp(KeyCode.LeftShift))
            rb.AddForce(0, 0, 0, ForceMode.Impulse);

        /* if (Input.GetButtonDown("Fire1"))
         {
             anim.SetBool("spin", true);
         }
         else if (Input.GetButtonDown("Fire2"))
         {
             anim.SetBool("spins", true);
         }
         else if (Input.GetButtonDown("Fire3"))
         {
             anim.SetBool("backs", true);
         }
         else
         {
             anim.SetBool("spin", false);
             anim.SetBool("spins", false);
             anim.SetBool("backs", false);
         }*/

    }
}
