using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderSample
{
    class ActorController//指挥者
    {
        //逐步构建复杂产品对象
        public Actor Construct(ActorBuliderBase ab)
        {
            Actor actor;
            ab.BuildType();
            ab.BuildSex();
            ab.BuildFace();
            ab.BuildCostume();
            ab.BuildHairstyle();
            actor = ab.CreateActor();
            return actor;
        }
    }
}
