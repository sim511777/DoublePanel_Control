using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DoublePanel {
    [Designer(typeof(DoublePanel_Designer))]
    public partial class DoublePanel : UserControl {
        public DoublePanel() {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel InnerPanel1 => pnlInner1;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel InnerPanel2 => pnlInner2;
    }

    internal class DoublePanel_Designer : ParentControlDesigner {
        public override void Initialize(System.ComponentModel.IComponent component) {
            base.Initialize(component);

            if (Control is DoublePanel control) {
                EnableDesignMode(control.InnerPanel1, "InnerPanel1");
                EnableDesignMode(control.InnerPanel2, "InnerPanel2");
            }
        }
    }
}
