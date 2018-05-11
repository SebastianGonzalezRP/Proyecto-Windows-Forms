namespace WindowsFormsApp4
{
    partial class Menu
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
            this.HTMenuArriendo = new System.Windows.Forms.Label();
            this.SalasDisponibles = new System.Windows.Forms.ListBox();
            this.SalaDisponibeLabel = new System.Windows.Forms.Label();
            this.ArrendarSalaBotton = new System.Windows.Forms.Button();
            this.AgregarAccesoriosBotton = new System.Windows.Forms.Button();
            this.ListaAcsesorios = new System.Windows.Forms.ListBox();
            this.AccesoriosLabel = new System.Windows.Forms.Label();
            this.Carrito = new System.Windows.Forms.ListBox();
            this.CarritoLabel = new System.Windows.Forms.Label();
            this.FinalizarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LNombreUsuario = new System.Windows.Forms.Label();
            this.BCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HTMenuArriendo
            // 
            this.HTMenuArriendo.AutoSize = true;
            this.HTMenuArriendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.HTMenuArriendo.Location = new System.Drawing.Point(5, 9);
            this.HTMenuArriendo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HTMenuArriendo.Name = "HTMenuArriendo";
            this.HTMenuArriendo.Size = new System.Drawing.Size(227, 37);
            this.HTMenuArriendo.TabIndex = 0;
            this.HTMenuArriendo.Text = "Menu Arriendo";
            // 
            // SalasDisponibles
            // 
            this.SalasDisponibles.FormattingEnabled = true;
            this.SalasDisponibles.ItemHeight = 20;
            this.SalasDisponibles.Location = new System.Drawing.Point(12, 117);
            this.SalasDisponibles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalasDisponibles.Name = "SalasDisponibles";
            this.SalasDisponibles.Size = new System.Drawing.Size(154, 264);
            this.SalasDisponibles.TabIndex = 1;
            // 
            // SalaDisponibeLabel
            // 
            this.SalaDisponibeLabel.AutoSize = true;
            this.SalaDisponibeLabel.Location = new System.Drawing.Point(8, 92);
            this.SalaDisponibeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalaDisponibeLabel.Name = "SalaDisponibeLabel";
            this.SalaDisponibeLabel.Size = new System.Drawing.Size(135, 20);
            this.SalaDisponibeLabel.TabIndex = 2;
            this.SalaDisponibeLabel.Text = "Salas Disponibles";
            // 
            // ArrendarSalaBotton
            // 
            this.ArrendarSalaBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ArrendarSalaBotton.Location = new System.Drawing.Point(135, 389);
            this.ArrendarSalaBotton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ArrendarSalaBotton.Name = "ArrendarSalaBotton";
            this.ArrendarSalaBotton.Size = new System.Drawing.Size(117, 44);
            this.ArrendarSalaBotton.TabIndex = 5;
            this.ArrendarSalaBotton.Text = "Arrendar Sala";
            this.ArrendarSalaBotton.UseVisualStyleBackColor = true;
            // 
            // AgregarAccesoriosBotton
            // 
            this.AgregarAccesoriosBotton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AgregarAccesoriosBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AgregarAccesoriosBotton.Location = new System.Drawing.Point(256, 389);
            this.AgregarAccesoriosBotton.Name = "AgregarAccesoriosBotton";
            this.AgregarAccesoriosBotton.Size = new System.Drawing.Size(80, 44);
            this.AgregarAccesoriosBotton.TabIndex = 6;
            this.AgregarAccesoriosBotton.Text = "Agregar Accesorios";
            this.AgregarAccesoriosBotton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarAccesoriosBotton.UseVisualStyleBackColor = true;
            // 
            // ListaAcsesorios
            // 
            this.ListaAcsesorios.FormattingEnabled = true;
            this.ListaAcsesorios.ItemHeight = 20;
            this.ListaAcsesorios.Location = new System.Drawing.Point(182, 117);
            this.ListaAcsesorios.Name = "ListaAcsesorios";
            this.ListaAcsesorios.Size = new System.Drawing.Size(154, 264);
            this.ListaAcsesorios.TabIndex = 2;
            // 
            // AccesoriosLabel
            // 
            this.AccesoriosLabel.AutoSize = true;
            this.AccesoriosLabel.Location = new System.Drawing.Point(178, 92);
            this.AccesoriosLabel.Name = "AccesoriosLabel";
            this.AccesoriosLabel.Size = new System.Drawing.Size(87, 20);
            this.AccesoriosLabel.TabIndex = 6;
            this.AccesoriosLabel.Text = "Accesorios";
            // 
            // Carrito
            // 
            this.Carrito.FormattingEnabled = true;
            this.Carrito.ItemHeight = 20;
            this.Carrito.Location = new System.Drawing.Point(355, 117);
            this.Carrito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Carrito.Name = "Carrito";
            this.Carrito.Size = new System.Drawing.Size(154, 264);
            this.Carrito.TabIndex = 3;
            // 
            // CarritoLabel
            // 
            this.CarritoLabel.AutoSize = true;
            this.CarritoLabel.Location = new System.Drawing.Point(351, 92);
            this.CarritoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CarritoLabel.Name = "CarritoLabel";
            this.CarritoLabel.Size = new System.Drawing.Size(56, 20);
            this.CarritoLabel.TabIndex = 8;
            this.CarritoLabel.Text = "Carrito";
            // 
            // FinalizarButton
            // 
            this.FinalizarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FinalizarButton.Location = new System.Drawing.Point(342, 389);
            this.FinalizarButton.Name = "FinalizarButton";
            this.FinalizarButton.Size = new System.Drawing.Size(100, 44);
            this.FinalizarButton.TabIndex = 7;
            this.FinalizarButton.Text = "Finalizar";
            this.FinalizarButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(12, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Devolver Sala";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.Location = new System.Drawing.Point(8, 51);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(281, 20);
            this.LNombreUsuario.TabIndex = 11;
            this.LNombreUsuario.Text = "ACA VA EL NOMBRE DEL USUARIO";
            // 
            // BCerrarSesion
            // 
            this.BCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BCerrarSesion.Location = new System.Drawing.Point(448, 389);
            this.BCerrarSesion.Name = "BCerrarSesion";
            this.BCerrarSesion.Size = new System.Drawing.Size(61, 44);
            this.BCerrarSesion.TabIndex = 8;
            this.BCerrarSesion.Text = "Cerrar Sesion";
            this.BCerrarSesion.UseVisualStyleBackColor = true;
            this.BCerrarSesion.Click += new System.EventHandler(this.BCerrarSesion_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 439);
            this.Controls.Add(this.BCerrarSesion);
            this.Controls.Add(this.LNombreUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FinalizarButton);
            this.Controls.Add(this.CarritoLabel);
            this.Controls.Add(this.Carrito);
            this.Controls.Add(this.AccesoriosLabel);
            this.Controls.Add(this.ListaAcsesorios);
            this.Controls.Add(this.AgregarAccesoriosBotton);
            this.Controls.Add(this.ArrendarSalaBotton);
            this.Controls.Add(this.SalaDisponibeLabel);
            this.Controls.Add(this.SalasDisponibles);
            this.Controls.Add(this.HTMenuArriendo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 478);
            this.MinimumSize = new System.Drawing.Size(535, 478);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HTMenuArriendo;
        private System.Windows.Forms.ListBox SalasDisponibles;
        private System.Windows.Forms.Label SalaDisponibeLabel;
        private System.Windows.Forms.Button ArrendarSalaBotton;
        private System.Windows.Forms.Button AgregarAccesoriosBotton;
        private System.Windows.Forms.ListBox ListaAcsesorios;
        private System.Windows.Forms.Label AccesoriosLabel;
        private System.Windows.Forms.ListBox Carrito;
        private System.Windows.Forms.Label CarritoLabel;
        private System.Windows.Forms.Button FinalizarButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LNombreUsuario;
        private System.Windows.Forms.Button BCerrarSesion;
    }
}

