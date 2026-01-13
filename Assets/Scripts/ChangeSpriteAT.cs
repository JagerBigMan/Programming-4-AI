using NodeCanvas.Framework;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions
{

    public class ChangeSpriteAT : ActionTask
    {
        public BBParameter<GameObject> targetPlane;
        public BBParameter<Sprite> newSprite;

        protected override void OnExecute()
        {
            if (targetPlane.value == null || newSprite.value == null)
            {
                EndAction(false);
                return;
            }

            MeshRenderer mr = targetPlane.value.GetComponent<MeshRenderer>();

            if (mr == null)
            {
                EndAction(false);
                return;
            }

            mr.material.SetTexture("_BaseMap", newSprite.value.texture);

            EndAction(true);
        }
    }
}