using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersProgramm
{
    public class OrderProductFlyoutMenuItem
    {
        public OrderProductFlyoutMenuItem()
        {
            TargetType = typeof(OrderProductFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}