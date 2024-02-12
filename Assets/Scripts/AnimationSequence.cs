using System.Collections;
using UnityEngine;

public class AnimationSequence : MonoBehaviour
{
    // Game Object Animators
    public Animator YerAndOyAnim;
    public Animator YerAnim;
    public Animator ChorrahaAnim;
    public Animator ShakillarAnim;
    public Animator RulesAnim;

    // Game Objects
    public GameObject YerAndOy;
    public GameObject Yer;
    public GameObject Chorraha;
    public GameObject Shakillar;
    public GameObject Rules;
    public GameObject _mainCamera;
    public GameObject Mendeleyv;

    public Material newSkybox;
    private Material originalSkybox;

    public Vector3 targetPosition = new Vector3(5f, 2f, -5f);

    void Start()
    {
        originalSkybox = RenderSettings.skybox;
        StartCoroutine(Animators());
    }

    private IEnumerator Animators()
    {
        // Animation 1
        YerAndOyAnim.SetBool("YerAndOy", true);
        yield return new WaitForSeconds(5.2f);
        YerAndOy.SetActive(false);
        Yer.SetActive(true);

        // Animation 2
        yield return new WaitForSeconds(4.30f);
        _mainCamera.transform.position = new Vector3(2.17f, 6.87f, -8f);
        _mainCamera.transform.rotation = Quaternion.Euler(31.356f, -25.995f, 0);
        Yer.SetActive(false);
        Chorraha.SetActive(true);

        // Animation 3
        RenderSettings.skybox = newSkybox;
        yield return new WaitForSeconds(8f);     
        _mainCamera.transform.position = new Vector3(0, 0, 0);
        _mainCamera.transform.rotation = Quaternion.Euler(0, 0, 0);
        Chorraha.SetActive(false);
        Rules.SetActive(true);

        // Animation 4 and 5
        RenderSettings.skybox = originalSkybox; // Move this line here
        yield return new WaitForSeconds(7f);
        Rules.SetActive(false);
        Shakillar.SetActive(true);
        Mendeleyv.SetActive(true);
    }
}
