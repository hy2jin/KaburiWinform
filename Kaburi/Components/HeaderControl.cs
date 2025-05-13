using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Drawing.Design;

namespace Kaburi.Components
{
    public partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();
        }


        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }

        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Description { get => lblDescription.Text; set => lblDescription.Text = value; }

    }
}
