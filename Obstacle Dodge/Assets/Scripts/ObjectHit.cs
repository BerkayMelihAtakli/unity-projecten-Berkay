using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   private void OnCollisionEnter(Collision other)
   {
        GetComponent<Renderer>().material.color = Color.red;
        Debug.Log("Something hit me!");
   }
}
