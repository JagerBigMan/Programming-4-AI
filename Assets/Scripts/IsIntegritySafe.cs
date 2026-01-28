using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class IsIntegritySafe : ConditionTask {

        public BBParameter<float> StructureIntegrity;
        public BBParameter<float> SafeThreshold = 15f;

		protected override bool OnCheck() 
		{
			return StructureIntegrity.value > SafeThreshold.value;
		}
	}
}