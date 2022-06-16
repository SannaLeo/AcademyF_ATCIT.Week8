using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AcademyF_ATCIT.Week8.EcommLogin.Messages
{
    public class DialogMessage
    {
        public string Content { get; set; } = null;
        public string Title { get; set; } = "Dialog";
        public MessageBoxImage Icon { get; set; } = MessageBoxImage.Information;
        public MessageBoxButton Button { get; set; } = MessageBoxButton.OK;
    }
}
