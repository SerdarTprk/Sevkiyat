using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevkiyat.UI
{
    public class Session
    {
        public static User CurrentUser { get; set; }
        public static Role CurrentRole { get; set; }
    }
}
