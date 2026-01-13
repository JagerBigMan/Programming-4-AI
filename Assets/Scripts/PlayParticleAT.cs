using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{

    public class PlayParticleAT : ActionTask
    {
        public BBParameter<ParticleSystem> particleSystem;

        protected override void OnExecute()
        {
            if (particleSystem.value == null)
            {
                EndAction(false);
                return;
            }

            particleSystem.value.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            particleSystem.value.Play();

        }

        protected override void OnUpdate()
        {
            if (!particleSystem.value.isPlaying)
            {
                EndAction(true);
            }
        }
    }
}


