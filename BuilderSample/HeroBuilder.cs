using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderSample
{
    class HeroBuilder : ActorBuliderBase//具体建造者
    {
        public override void BuildType()
        {
            mActor.Type = "英雄";
        }

        public override void BuildSex()
        {
            mActor.Sex = "男";
        }

        public override void BuildFace()
        {
            mActor.Face = "英俊";
        }

        public override void BuildCostume()
        {
            mActor.Costume = "盔甲";
        }

        public override void BuildHairstyle()
        {
            mActor.Hairstyle = "长发";
        }
    }
}
