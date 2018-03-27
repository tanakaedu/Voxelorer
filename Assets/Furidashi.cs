using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AM1.TPCMove;

namespace AM1
{
    public class Furidashi : MonoBehaviour
    {

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                other.GetComponent<FallOutDetector>().ToStartPoint();
            }
        }
    }
}
