using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderSample
{
    class AngelBuilder : ActorBuliderBase//具体建造者
    {
        public override void BuildType()
        {
            mActor.Type = "天使";
        }

        public override void BuildSex()
        {
            mActor.Sex = "女";
        }

        public override void BuildFace()
        {
            mActor.Face = "漂亮";
        }

        public override void BuildCostume()
        {
            mActor.Costume = "白裙";
        }

        public override void BuildHairstyle()
        {
            mActor.Hairstyle = "披肩长发";
        }
    }
}
