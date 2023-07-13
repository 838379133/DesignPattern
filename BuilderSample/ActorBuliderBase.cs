using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderSample
{
    abstract class ActorBuliderBase //抽象建造者
    {
        protected Actor mActor = new Actor();

        public abstract void BuildType();
        public abstract void BuildSex();
        public abstract void BuildFace();
        public abstract void BuildCostume();
        public abstract void BuildHairstyle();

        //工厂方法 返回完整的游戏角色对象
        public Actor CreateActor()
        {
            return mActor;
        }
    }
}
