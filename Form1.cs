using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LibraryPersonal;

namespace Puntero_Windows
{
    public partial class Form1 : Form
    {
        SimulateInteraction simulate;
        TcpServerCode server;
        Thread t;
        public static Form1 Singletone;

        public Form1()
        {
            InitializeComponent();
            Singletone = this;
            server = new TcpServerCode(5656);
            t = new Thread(()=> { server.StartServer(); });
            t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ShowIp.Text = "La IP Local de este dispositivo es :          \n" + string.Join("\n", Datos.MiIp().ToArray());
            simulate = new SimulateInteraction(this);
        }

        public void Interprete(string o)
        {
            Console.WriteLine(o);
            ShowLog.Items.Add(o);
            if(o == "r")
            {
                simulate.KeyRightDown();
            }
            else if(o == "l")
            {
                simulate.KeyLeftDown();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
