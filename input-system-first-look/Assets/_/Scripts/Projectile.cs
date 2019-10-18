namespace GiantCroissant.InputSystemFirstLook
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Projectile : MonoBehaviour
    {
        public float speed;

        void Start()
        {
            StartCoroutine(DestructAfterCertainTime());
        }

        IEnumerator DestructAfterCertainTime()
        {
            yield return new WaitForSeconds(6.0f);
            Destroy(gameObject);
        }
        
        void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 100.0f, 0), Time.deltaTime * speed);
        }
    }
}
