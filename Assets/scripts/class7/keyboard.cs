
using UnityEngine;

public class keyboard : MonoBehaviour
{
    Vector3 target = new Vector3(12, 3, -1);
    void start()
    {
        
        transform.Translate(0,0,0);
    }
    void Update(){
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime);
        transform. Translate (vec);

        /*
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime);
        transform. Translate (vec);*/
        
        /*
        //1. MoveTowards

        transform.position =
        Vector3. MoveTowards(transform.position
        , target, 2f);


        //2. SmoothDamp
        Vector3 velo = Vector3. zero;
        transform.position =
            Vector3.SmoothDamp(transform.position
                , target, ref velo, 0.1f);


        //3. Lerp
        transform.position =
            Vector3. Lerp(transform.position
                , target, 0.5f);

        transform.position =
            Vector3. Slerp(transform.position
                , target, 0.5f);*/

    }
}
