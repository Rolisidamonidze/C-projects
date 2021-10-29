
namespace TicTacToe {
   partial class MainForm {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btn8 = new System.Windows.Forms.Button();
         this.btn5 = new System.Windows.Forms.Button();
         this.btn2 = new System.Windows.Forms.Button();
         this.btn7 = new System.Windows.Forms.Button();
         this.btn4 = new System.Windows.Forms.Button();
         this.btn6 = new System.Windows.Forms.Button();
         this.btn1 = new System.Windows.Forms.Button();
         this.btn3 = new System.Windows.Forms.Button();
         this.btn0 = new System.Windows.Forms.Button();
         this.lblResult = new System.Windows.Forms.Label();
         this.menuStrip1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // statusStrip1
         // 
         this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.statusStrip1.Location = new System.Drawing.Point(0, 557);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(500, 22);
         this.statusStrip1.TabIndex = 0;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // menuStrip1
         // 
         this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(500, 28);
         this.menuStrip1.TabIndex = 1;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // gameToolStripMenuItem
         // 
         this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
         this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
         this.gameToolStripMenuItem.Text = "Game";
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
         this.aboutToolStripMenuItem.Text = "About";
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.SystemColors.Menu;
         this.panel1.Controls.Add(this.lblResult);
         this.panel1.Controls.Add(this.btn8);
         this.panel1.Controls.Add(this.btn5);
         this.panel1.Controls.Add(this.btn2);
         this.panel1.Controls.Add(this.btn7);
         this.panel1.Controls.Add(this.btn4);
         this.panel1.Controls.Add(this.btn6);
         this.panel1.Controls.Add(this.btn1);
         this.panel1.Controls.Add(this.btn3);
         this.panel1.Controls.Add(this.btn0);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(0, 28);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(500, 529);
         this.panel1.TabIndex = 2;
         // 
         // btn8
         // 
         this.btn8.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.btn8.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.btn8.Location = new System.Drawing.Point(334, 398);
         this.btn8.Name = "btn8";
         this.btn8.Size = new System.Drawing.Size(155, 124);
         this.btn8.TabIndex = 0;
         this.btn8.Tag = "8";
         this.btn8.UseVisualStyleBackColor = false;
         this.btn8.Click += new System.EventHandler(this.button9_Click);
         // 
         // btn5
         // 
         this.btn5.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.btn5.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.btn5.Location = new System.Drawing.Point(334, 268);
         this.btn5.Name = "btn5";
         this.btn5.Size = new System.Drawing.Size(155, 124);
         this.btn5.TabIndex = 0;
         this.btn5.Tag = "5";
         this.btn5.UseVisualStyleBackColor = false;
         this.btn5.Click += new System.EventHandler(this.button6_Click);
         // 
         // btn2
         // 
         this.btn2.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.btn2.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.btn2.Location = new System.Drawing.Point(334, 138);
         this.btn2.Name = "btn2";
         this.btn2.Size = new System.Drawing.Size(155, 124);
         this.btn2.TabIndex = 0;
         this.btn2.Tag = "2";
         this.btn2.UseVisualStyleBackColor = false;
         this.btn2.Click += new System.EventHandler(this.button3_Click);
         // 
         // btn7
         // 
         this.btn7.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.btn7.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.btn7.Location = new System.Drawing.Point(173, 398);
         this.btn7.Name = "btn7";
         this.btn7.Size = new System.Drawing.Size(155, 124);
         this.btn7.TabIndex = 0;
         this.btn7.Tag = "7";
         this.btn7.UseVisualStyleBackColor = false;
         this.btn7.Click += new System.EventHandler(this.button8_Click);
         // 
         // btn4
         // 
         this.btn4.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.btn4.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.btn4.Location = new System.Drawing.Point(173, 268);
         this.btn4.Name = "btn4";
         this.btn4.Size = new System.Drawing.Size(155, 124);
         this.btn4.TabIndex = 0;
         this.btn4.Tag = "4";
         this.btn4.UseVisualStyleBackColor = false;
         this.btn4.Click += new System.EventHandler(this.button5_Click);
         // 
         // btn6
         // 
         this.btn6.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.btn6.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.btn6.Location = new System.Drawing.Point(12, 398);
         this.btn6.Name = "btn6";
         this.btn6.Size = new System.Drawing.Size(155, 124);
         this.btn6.TabIndex = 0;
         this.btn6.Tag = "6";
         this.btn6.UseVisualStyleBackColor = false;
         this.btn6.Click += new System.EventHandler(this.button7_Click);
         // 
         // btn1
         // 
         this.btn1.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.btn1.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.btn1.Location = new System.Drawing.Point(173, 138);
         this.btn1.Name = "btn1";
         this.btn1.Size = new System.Drawing.Size(155, 124);
         this.btn1.TabIndex = 0;
         this.btn1.Tag = "1";
         this.btn1.UseVisualStyleBackColor = false;
         this.btn1.Click += new System.EventHandler(this.button2_Click);
         // 
         // btn3
         // 
         this.btn3.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.btn3.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.btn3.Location = new System.Drawing.Point(12, 268);
         this.btn3.Name = "btn3";
         this.btn3.Size = new System.Drawing.Size(155, 124);
         this.btn3.TabIndex = 0;
         this.btn3.Tag = "3";
         this.btn3.UseVisualStyleBackColor = false;
         this.btn3.Click += new System.EventHandler(this.button4_Click);
         // 
         // btn0
         // 
         this.btn0.BackColor = System.Drawing.SystemColors.InactiveCaption;
         this.btn0.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.btn0.Location = new System.Drawing.Point(12, 138);
         this.btn0.Name = "btn0";
         this.btn0.Size = new System.Drawing.Size(155, 124);
         this.btn0.TabIndex = 0;
         this.btn0.Tag = "0";
         this.btn0.UseVisualStyleBackColor = false;
         this.btn0.Click += new System.EventHandler(this.button1_Click);
         // 
         // lblResult
         // 
         this.lblResult.AutoSize = true;
         this.lblResult.Location = new System.Drawing.Point(12, 55);
         this.lblResult.Name = "lblResult";
         this.lblResult.Size = new System.Drawing.Size(0, 20);
         this.lblResult.TabIndex = 1;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(500, 579);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "MainForm";
         this.Text = "Form1";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btn8;
      private System.Windows.Forms.Button btn5;
      private System.Windows.Forms.Button btn2;
      private System.Windows.Forms.Button btn7;
      private System.Windows.Forms.Button btn4;
      private System.Windows.Forms.Button btn6;
      private System.Windows.Forms.Button btn1;
      private System.Windows.Forms.Button btn3;
      private System.Windows.Forms.Button btn0;
      private System.Windows.Forms.Label lblResult;
   }
}

