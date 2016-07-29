using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynAwaitExperiment {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void cmdDoFast_Click(object sender, EventArgs e) {
      lblFastResult.Text = "calculating...";
      lblFastResult.Text = NumberGetter.GetRandom().ToString();
    }

    private void cmdDoSlow_Click(object sender, EventArgs e) {
      lblSlowResult.Text = "calculating...";
      int number = NumberGetter.GetRandomSlowly();
      lblSlowResult.Text = number.ToString();
    }

    private async void cmdDoSlowAsync_Click(object sender, EventArgs e) {
      lblSlowAsyncResult.Text = "calculating...";
      int number = await NumberGetter.GetRandomAsync();
      lblSlowAsyncResult.Text = number.ToString();
    }
  }
}
