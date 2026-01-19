using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class IntegrityDecayTick : ActionTask 
	{
		public BBParameter<float> structuralIntegrity;
		public BBParameter<float> stressLevel;

		public float baseDecayPerSecond = 1f;
		public float stressMultiplier = 1.5f;
		public float minIntegrity = 0f;
		public float maxIntegrity = 100f;

		protected override void OnUpdate() 
		{
			float stress01 = Mathf.Clamp01(stressLevel.value / 100f);		//I'm normalizing the stress so it becomes a clean multiplier from 0-100 to 0-1
			float decay = baseDecayPerSecond * (1f + stress01 * stressMultiplier);		//This calculated the decay rate, if no stress then decay = baseDecay, high stress = decay increases

			structuralIntegrity.value = Mathf.Clamp(							//Apply decay to integrity, subtracts decay over time, clamps result between 0-100, writes it back to the blackboard
				structuralIntegrity.value - decay * Time.deltaTime,
				minIntegrity, maxIntegrity);
		}
	}
}