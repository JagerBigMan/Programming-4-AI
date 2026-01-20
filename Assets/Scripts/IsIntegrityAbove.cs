using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace NodeCanvas.Tasks.Conditions {

	public class IsIntegrityAbove : ConditionTask 
	{
		public BBParameter<float> structuralIntegrity;
		public float threshold = 80f;
		protected override bool OnCheck() 
		{
			return structuralIntegrity.value > threshold;
		}
	}
}