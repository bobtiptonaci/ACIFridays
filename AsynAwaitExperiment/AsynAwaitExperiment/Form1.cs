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

    private void cmdDoSlowAsync_Click(object sender, EventArgs e) {
      txtOutput.Text = string.Empty;
      txtOutput.Text += "About to call...\r\n";
      ActuallyGetNumber();
      txtOutput.Text += "When did I happen?\r\n";
    }

    private async void dosomething() {

    }
    private async void ActuallyGetNumber() {
      lblSlowAsyncResult.Text = "calculating...";
      txtOutput.Text += "Set calculating caption\r\n";
      int number = await NumberGetter.GetRandomAsync();
      txtOutput.Text += "Got random number\r\n";
      lblSlowAsyncResult.Text = number.ToString();
      txtOutput.Text += "Displayed random number\r\n";
    }
  }
}
