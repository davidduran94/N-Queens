using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backtracking_n_reinas.Logic;

namespace Backtracking_n_reinas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backtracking back = new Backtracking(8);
            List<Tablero> tab = new List<Tablero>();
            int[] inicial = new int[8];
            inicial[0] = -1;
            inicial[1] = -1;
            inicial[2] = -1;
            inicial[3] = -1;
            inicial[4] = -1;
            inicial[5] = -1;
            inicial[6] = -1;
            inicial[7] = -1;
            //inicial[4] = -1;
            //inicial[5] = -1;
            //inicial[6] = -1;
            //inicial[7] = -1;
            int cr=0;
            bool exito  = back.funcionReinas(inicial, 0, ref tab, ref cr);
            if (!exito){
                textBox1.Text = "no hay solucion";
            }
            
                int final = tab.ToArray().Length;
                Tablero[] tabs = tab.ToArray();
                textBox1.Text += tabs[final-1].toString();
            
        }
    }
}
