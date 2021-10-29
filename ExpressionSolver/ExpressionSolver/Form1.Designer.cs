
namespace ExpressionSolver {
   partial class ExpressionSolver {
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
         this.btnSolve = new System.Windows.Forms.Button();
         this._textBox = new System.Windows.Forms.TextBox();
         this.lblResult = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnSolve
         // 
         this.btnSolve.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.btnSolve.Location = new System.Drawing.Point(189, 50);
         this.btnSolve.Name = "btnSolve";
         this.btnSolve.Size = new System.Drawing.Size(75, 23);
         this.btnSolve.TabIndex = 0;
         this.btnSolve.Text = "Solve";
         this.btnSolve.UseVisualStyleBackColor = true;
         this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
         // 
         // _textBox
         // 
         this._textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this._textBox.Location = new System.Drawing.Point(12, 12);
         this._textBox.Name = "_textBox";
         this._textBox.Size = new System.Drawing.Size(442, 20);
         this._textBox.TabIndex = 1;
         // 
         // lblResult
         // 
         this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
         this.lblResult.AutoSize = true;
         this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.lblResult.Location = new System.Drawing.Point(195, 98);
         this.lblResult.Name = "lblResult";
         this.lblResult.Size = new System.Drawing.Size(54, 29);
         this.lblResult.TabIndex = 2;
         this.lblResult.Text = "test";
         // 
         // ExpressionSolver
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(466, 151);
         this.Controls.Add(this.lblResult);
         this.Controls.Add(this._textBox);
         this.Controls.Add(this.btnSolve);
         this.Name = "ExpressionSolver";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnSolve;
      private System.Windows.Forms.TextBox _textBox;
      private System.Windows.Forms.Label lblResult;
   }
}

