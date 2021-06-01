using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody2D rigid;
	[SerializeField] float speed = 5f;
	[SerializeField] bool isFacingRight = true;
    [SerializeField] Vector2 movement;
    
    
    
    void Start()
    {
        if (rigid == null)
			rigid = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
    }

    void FixedUpdate()
	{
        
        //rigid.velocity = new Vector2(movement * speed, rigid.velocity.y);
        //rigid.velocity = new Vector2(movement2 * speed, rigid.velocity.x);
        Vector2 moveY =  new Vector2(movement.x * speed, rigid.velocity.y);
        Vector2 moveX =  new Vector2(rigid.velocity.x,movement.y * speed);
        rigid.velocity = moveY;
        rigid.velocity = moveX;
        rigid.MovePosition(rigid.position + movement * speed * Time.fixedDeltaTime);
        if (movement.x < 0 && isFacingRight || movement.x > 0 && !isFacingRight)
            Flip();
		//if (movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
			//Flip();
	}
    void Flip()
    {
        //Vector3 playerScale = transform.localScale;
        //playerScale.x = playerScale.x * -1;
        //transform.localScale = playerScale;

        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f, 0f);

        //isFacingRight = !isFacingRight;
    }

}
