using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderSample
{
    class DevilVuilder : ActorBuliderBase
    {
        public override void BuildType()
        {
            mActor.Type = "恶魔";
        }

        public override void BuildSex()
        {
            mActor.Sex = "妖";
        }

        public override void BuildFace()
        {
            mActor.Face = "丑陋";
        }

        public override void BuildCostume()
        {
            mActor.Costume = "黑衣";
        }

        public override void BuildHairstyle()
        {
            mActor.Hairstyle = "光头";
        }
    }
}
