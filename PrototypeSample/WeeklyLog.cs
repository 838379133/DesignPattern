using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeSample
{
    class WeeklyLog
    {
        //为简化设计 假设周报忠只有一个附件
        private Attachment attachment;
        private string name;
        private string date;
        private string content;

        public Attachment Attachment
        {
            get { return attachment; }
            set { attachment = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        //使用MenberwiseClone()方法实现浅克隆
        public WeeklyLog Clone()
        {
            return this.MemberwiseClone() as WeeklyLog;
        }
    }
}
