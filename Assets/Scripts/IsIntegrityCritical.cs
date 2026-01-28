using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class IsIntegrityCritical : ConditionTask {

		public BBParameter<float> StructureIntegrity;
		public BBParameter<float> CriticalThreshold = 10f;
	
		protected override bool OnCheck() {
			return StructureIntegrity.value <=CriticalThreshold.value;
		}
	}
}