namespace Drawing_Canvas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.blankCanvas = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blankCanvas
            // 
            this.blankCanvas.BackColor = System.Drawing.Color.White;
            this.blankCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blankCanvas.Location = new System.Drawing.Point(120, 70);
            this.blankCanvas.Name = "blankCanvas";
            this.blankCanvas.Size = new System.Drawing.Size(428, 304);
            this.blankCanvas.TabIndex = 0;
            this.blankCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            this.blankCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseMove);
            this.blankCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseUp);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(120, 389);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.blankCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel blankCanvas;
        private System.Windows.Forms.Button clearBtn;
    }
}

