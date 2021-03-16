using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumiere.Pages
{
    public class HomeFlyoutMenuItem
    {
        public HomeFlyoutMenuItem()
        {
            TargetType = typeof(HomeFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}