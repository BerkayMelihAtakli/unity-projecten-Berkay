using UnityEngine;

public class Scorer : MonoBehaviour
{
   private void OncollisionEnter(Collision other)
   {
        Debug.Log("You've bumped into a thing this many times!");
   }
}
