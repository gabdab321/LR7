namespace LR7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addButton = new Button();
            flowerPanel = new Panel();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 412);
            addButton.Name = "addButton";
            addButton.Size = new Size(107, 26);
            addButton.TabIndex = 0;
            addButton.Text = "Додати квітку";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // flowerPanel
            // 
            flowerPanel.BorderStyle = BorderStyle.FixedSingle;
            flowerPanel.Location = new Point(12, 12);
            flowerPanel.Name = "flowerPanel";
            flowerPanel.Size = new Size(567, 349);
            flowerPanel.TabIndex = 1;
            flowerPanel.Paint += flowerPanel_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowerPanel);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Panel flowerPanel;
    }
}
