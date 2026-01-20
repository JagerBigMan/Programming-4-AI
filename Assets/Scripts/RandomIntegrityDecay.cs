using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class RandomIntegrityDecay : ActionTask
		{
		public BBParameter<float> structuralIntegrity;

		public float minDamage = 5f;
		public float maxDamage = 20f;

		public float minInterval = 3f;
		public float maxInterval = 8f;

		public float minIntegrity = 0f;
		public float maxIntegrity = 100f;

		private float timer;
		private float nextHitTime;
		protected override void OnExecute() 
		{
			ScheduleNextHit();
		}
		protected override void OnUpdate()
		{
			timer += Time.deltaTime;

            if (timer >= nextHitTime)
            {
                float damage = Random.Range(minDamage, maxDamage);

				structuralIntegrity.value = Mathf.Clamp(structuralIntegrity.value - damage, minIntegrity, maxIntegrity);

				ScheduleNextHit();
            }
        }

		void ScheduleNextHit()
		{
			timer = 0f;
			nextHitTime = Random.Range(minInterval, maxInterval);
		}
	}
}