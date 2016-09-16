namespace AsynAwaitExperiment {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.cmdDoSlow = new System.Windows.Forms.Button();
      this.cmdDoFast = new System.Windows.Forms.Button();
      this.lblSlowResult = new System.Windows.Forms.Label();
      this.lblFastResult = new System.Windows.Forms.Label();
      this.lblSlowAsyncResult = new System.Windows.Forms.Label();
      this.cmdDoSlowAsync = new System.Windows.Forms.Button();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // cmdDoSlow
      // 
      this.cmdDoSlow.Location = new System.Drawing.Point(103, 51);
      this.cmdDoSlow.Name = "cmdDoSlow";
      this.cmdDoSlow.Size = new System.Drawing.Size(187, 23);
      this.cmdDoSlow.TabIndex = 0;
      this.cmdDoSlow.Text = "Do Something Slow";
      this.cmdDoSlow.UseVisualStyleBackColor = true;
      this.cmdDoSlow.Click += new System.EventHandler(this.cmdDoSlow_Click);
      // 
      // cmdDoFast
      // 
      this.cmdDoFast.Location = new System.Drawing.Point(103, 155);
      this.cmdDoFast.Name = "cmdDoFast";
      this.cmdDoFast.Size = new System.Drawing.Size(187, 23);
      this.cmdDoFast.TabIndex = 1;
      this.cmdDoFast.Text = "Do Something Fast";
      this.cmdDoFast.UseVisualStyleBackColor = true;
      this.cmdDoFast.Click += new System.EventHandler(this.cmdDoFast_Click);
      // 
      // lblSlowResult
      // 
      this.lblSlowResult.Location = new System.Drawing.Point(338, 56);
      this.lblSlowResult.Name = "lblSlowResult";
      this.lblSlowResult.Size = new System.Drawing.Size(100, 23);
      this.lblSlowResult.TabIndex = 2;
      // 
      // lblFastResult
      // 
      this.lblFastResult.Location = new System.Drawing.Point(338, 160);
      this.lblFastResult.Name = "lblFastResult";
      this.lblFastResult.Size = new System.Drawing.Size(100, 23);
      this.lblFastResult.TabIndex = 3;
      // 
      // lblSlowAsyncResult
      // 
      this.lblSlowAsyncResult.Location = new System.Drawing.Point(338, 107);
      this.lblSlowAsyncResult.Name = "lblSlowAsyncResult";
      this.lblSlowAsyncResult.Size = new System.Drawing.Size(100, 23);
      this.lblSlowAsyncResult.TabIndex = 5;
      // 
      // cmdDoSlowAsync
      // 
      this.cmdDoSlowAsync.Location = new System.Drawing.Point(103, 102);
      this.cmdDoSlowAsync.Name = "cmdDoSlowAsync";
      this.cmdDoSlowAsync.Size = new System.Drawing.Size(187, 23);
      this.cmdDoSlowAsync.TabIndex = 4;
      this.cmdDoSlowAsync.Text = " Do Something Slow (Async)";
      this.cmdDoSlowAsync.UseVisualStyleBackColor = true;
      this.cmdDoSlowAsync.Click += new System.EventHandler(this.cmdDoSlowAsync_Click);
      // 
      // txtOutput
      // 
      this.txtOutput.Location = new System.Drawing.Point(453, 51);
      this.txtOutput.Multiline = true;
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.Size = new System.Drawing.Size(220, 200);
      this.txtOutput.TabIndex = 6;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(709, 407);
      this.Controls.Add(this.txtOutput);
      this.Controls.Add(this.lblSlowAsyncResult);
      this.Controls.Add(this.cmdDoSlowAsync);
      this.Controls.Add(this.lblFastResult);
      this.Controls.Add(this.lblSlowResult);
      this.Controls.Add(this.cmdDoFast);
      this.Controls.Add(this.cmdDoSlow);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cmdDoSlow;
    private System.Windows.Forms.Button cmdDoFast;
    private System.Windows.Forms.Label lblSlowResult;
    private System.Windows.Forms.Label lblFastResult;
    private System.Windows.Forms.Label lblSlowAsyncResult;
    private System.Windows.Forms.Button cmdDoSlowAsync;
    private System.Windows.Forms.TextBox txtOutput;
  }
}

