using UnityEngine;

namespace EdibleInedible
{
    public class MoveDown : MonoBehaviour
    {
        private void FixedUpdate()
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,
                gameObject.transform.position.y - 0.1f, gameObject.transform.position.z);
            if (gameObject.transform.position.y < -24f)
            {
                Destroy(gameObject);
            }
            
        }
    }
}