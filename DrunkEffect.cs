using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Drunk Effect")]
public class DrunkEffect: ImageEffectBase {
	public Vector2  radius = new Vector2(1.0F,1.0F);
	public float power = 40;
	public float speed = 1.0f;
	float angle = 0;
	float angleRun = 0;
	public Vector2  center = new Vector2 (0.5F, 0.5F);

	// Called by camera to apply image effect
	void OnRenderImage (RenderTexture source, RenderTexture destination) {
		angleRun += speed * Time.deltaTime;
		angle = Mathf.Sin(angleRun) * power;
		ImageEffects.RenderDistortion (material, source, destination, angle, center, radius);
	}
}
