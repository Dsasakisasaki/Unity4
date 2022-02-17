using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //RaycastHitは構造体
            //RaycastHit hit;

            //hitはnullなので本来なら引数渡せない　がoutと書けばメッソド内で値が入るという宣言
            /*if(Physics.Raycast(ray,out hit, 100f))
            {
                Debug.Log(hit.point);
                Destroy(hit.collider.gameObject);
            }
            */

            //for(RaycastHit hit :Physics.RaycastAll(ray){} javaの拡張for分だとこう　↓
            foreach (RaycastHit hit in Physics.RaycastAll(ray))//RaycastHit構造体の配列が返ってくるのでそれを回して消していく
            //RaycastAll(ray)　で光線にぶつかった物をRaycastHit構造体として返す複数なので配列で返ってくる
            {
                Destroy(hit.collider.gameObject);
            }
           
              //foreach (RaycastHit hit in Physics.SphereCastAll(ray,3f)) {
               //Destroy(hit.collider.gameObject);
              //}
            
        }
    }

}
