using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenRepositoryCode()
    {
        Application.OpenURL("https://github.com/washingtonpanganai/CarCollisionAlpha.git");
    }
}
