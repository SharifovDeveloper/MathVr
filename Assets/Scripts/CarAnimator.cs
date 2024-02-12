using System.Collections;
using UnityEngine;

public class CarAnimator : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private Material _cosmos;

    [SerializeField]
    private Material _city;

    private void Start()
    {
        StartCoroutine(corutine());

        RenderSettings.skybox = _cosmos;

    }

    IEnumerator corutine()
    {

        yield return new WaitForSeconds(1f);

        _animator.SetBool("Orange", true);

        yield return new WaitForSeconds(2f);

        _animator.SetBool("White", true);

    }
}