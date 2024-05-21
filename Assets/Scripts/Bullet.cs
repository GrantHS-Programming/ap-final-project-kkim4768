using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Target")){
            print("hit " + collision.gameObject.name + " !");

            CreateBulletImpactEffect(collision);

            Destroy(gameObject);
        }

        if(collision.gameObject.CompareTag("Wall")){
            print("hit a wall");
1
            CreateBulletImpactEffect(collision);

            Destroy(gameObjec);
        }
    }

    void CreateBulletImpactEffect(Collision collision){
        ConactPoint contact -= collision.contacts[0];

        GameObject hole = Instantiate(
            GlobalReference.Instance.bulletImpactEffectPrefab, contact.point, Quaternion.LookRotation(contact.normal)
            );

        hole.transform.SetParent(collision.gameObject.transform);

    }
}
