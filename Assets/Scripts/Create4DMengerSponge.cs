using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Mathematics.math;

public class Create4DMengerSponge : MonoBehaviour
{
   public Shape4D hypercube;
   
  
   void Start()
   {
        // hypercube.shapeType = Shape4D.ShapeType.HyperCube;
        // hypercube.operation = Shape4D.Operation.Union;
        for (int x=-1; x<=1; ++x)
        {
           for (int y=-1; y<=1; ++y)
           {
                for (int z=-1; z<=1; ++z)
                {
                    for (int w=-1; w<=1; ++w)
                    {
                        if ( (abs(x) + abs(y) + abs(z) + abs(w)) > 2 )
                        {
                            hypercube = Instantiate(hypercube, new Vector3(x,y,z), Quaternion.identity);
                            hypercube.scaleW = 0.5f;
                            hypercube.positionW = w;
                            Debug.Log("<" + x + ", " + y + ", " + z + ", " + w + ">");
                        } 
                    }
                }
           }
       }       
   }
}
