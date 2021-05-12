using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Mathematics.math;

public class RandomHyperEliipses : MonoBehaviour
{
   public Shape4D hyperellipse;
   
  
   void Start()
   {
        // hypercube.shapeType = Shape4D.ShapeType.HyperCube;
        // hypercube.operation = Shape4D.Operation.Union;
        for (int i=0; i<10; ++i)
        {
            float x = Random.Range(-2.0f, 2.0f);
            float y = Random.Range(-2.0f, 2.0f);
            float z = Random.Range(-2.0f, 2.0f);
            hyperellipse = Instantiate(hyperellipse, new Vector3(x,y,z), Quaternion.identity);
            hyperellipse.transform.localScale = float3(Random.Range(0.0f, 2.0f), Random.Range(0.0f, 2.0f), Random.Range(0.0f, 2.0f));
            hyperellipse.positionW = Random.Range(-2.0f, 2.0f);
            // hyperellipse.Scale.y = rnd.NextDouble()*5;
            // hyperellipse.Scale.z = rnd.NextDouble()*5;
            hyperellipse.scaleW = Random.Range(0.0f, 2.0f);
            hyperellipse.colour = new Vector4((x+2)/4, (y+2)/4, (z+2)/4, 0);
        }       
    }
}
