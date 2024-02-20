using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshToggle : MonoBehaviour
{
    [SerializeField] GameObject _turbineObject;
    bool _enabled = true;

    public void OnHandleToggle()
    {
        _enabled = !_enabled;
        _turbineObject.SetActive(_enabled);
    }
}
