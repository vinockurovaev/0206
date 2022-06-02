using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СтудентП31.Model
{
    public partial class Студент
    {
        public int Age
        {
            get
            {
                if (ДатаРождения == null)
                {
                    return 0;
                }
                var now = DateTime.Now;
                var diff = now - ДатаРождения;
                var years = diff.Value.Days / 365;

                return (int)years;
            }
        }
        public string BackColorAge
        {
            get
            {
                if (Age >= 17)
                    return "#7fff00";
                else
                    return "#eed4fe";

            }
        }



    }
}
