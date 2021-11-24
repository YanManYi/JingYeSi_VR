using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SkyBoxObject : MonoBehaviour
{



    public Material skyMaterial;

    public UnityEngine.Rendering.AmbientMode ambientMode;
    public float ambientIntencity;
    public Color skyColor = new Color(1,1,1,1);
    public Color equatorColor = new Color(1,1,1,1);
    public Color groundColor = new Color(1,1,1,1);


    public bool fogEnable;
    public Color fogColor;
    public FogMode fogMode;
    public float fogDensity;
    public float fogBegin = 0;
    public float fogEnd = 300;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddedToUEditorScene()
    {
       ApplySkybox();
    }

    public void GrabSceneLighting()
    {
        skyMaterial = RenderSettings.skybox;
        fogEnable = RenderSettings.fog;
        fogColor = RenderSettings.fogColor;
        fogMode = RenderSettings.fogMode;
        fogDensity = RenderSettings.fogDensity;
        fogBegin = RenderSettings.fogStartDistance;
        fogEnd = RenderSettings.fogEndDistance;

        ambientMode = RenderSettings.ambientMode;
        ambientIntencity = RenderSettings.ambientIntensity;
        skyColor = RenderSettings.ambientSkyColor;
        equatorColor = RenderSettings.ambientEquatorColor;
        groundColor = RenderSettings.ambientGroundColor;
    }

    public void DelFromUEditorScene()
    {
        ReverseSkyboxToDefault();
    }

    private void ApplySkybox()
    {
        if (skyMaterial)
        {
            RenderSettings.skybox = skyMaterial;
            RenderSettings.fog = fogEnable;
            RenderSettings.fogColor = fogColor;
            RenderSettings.fogMode = fogMode;
            RenderSettings.fogDensity = fogDensity;
            RenderSettings.fogStartDistance = fogBegin;
            RenderSettings.fogEndDistance = fogEnd;

            RenderSettings.ambientMode = ambientMode;
            RenderSettings.ambientIntensity = ambientIntencity;
            RenderSettings.ambientSkyColor = skyColor;
            RenderSettings.ambientEquatorColor = equatorColor;
            RenderSettings.ambientGroundColor = groundColor;

        

        }
    }

    void ReverseSkyboxToDefault()
    {
        return;
        RenderSettings.skybox = Resources.Load<Material>("Resources/unity_builtin_extra/Default-Skybox");
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Skybox;
        RenderSettings.fog = false;
    }

    void OnEnable()
    {
        ApplySkybox();
    }

    void OnDisable()
    {
        ReverseSkyboxToDefault();
    }
}
