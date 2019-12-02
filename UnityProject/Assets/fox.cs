using UnityEngine;

public class fox : MonoBehaviour
{
    public float speed = 10f,y=1f;
    public Rigidbody2D Rig;
    public SpriteRenderer Sr;
    
    //移動功能
    private void Move()
    {
        Vector2 pos = new Vector2( speed*Input.GetAxisRaw("Horizontal") * Time.deltaTime*10000f, y);

            if (Input.GetKeyDown(KeyCode.D))
            {
                print("D");
           

                Rig.AddForce(pos, ForceMode2D.Force);

                //狐狸翻面
                Sr.flipX = false;

             
            
            }
            else if(Input.GetKeyDown(KeyCode.A))
            {
                print("A");
            

                Rig.AddForce(pos, ForceMode2D.Force);

                //狐狸翻面
                Sr.flipX = true;

             
            }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
