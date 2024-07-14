using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Ground;
    // public float groundMoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.x - transform.position.x >= 5)
        {
            Debug.Log("Player at x axis of 5");
            // Ground.transform.position += new Vector3(-0.001f * groundMoveSpeed, 0, 0);
            //GroundScript groundScript = Ground.GetComponent<GroundScript>();
            //groundScript.moveGround = true;
          
            transform.position += new Vector3(0.01f * 2.25f, 0, 0); // Later change with player script movespeed value
            //    moveGround = false;
        }
    }
}
