using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class IsIntegrityBelow : ConditionTask 
	{
		public BBParameter<float> structuralIntegrity;
		public float threshold = 40f;
		protected override bool OnCheck() => structuralIntegrity.value < threshold;
	}
}