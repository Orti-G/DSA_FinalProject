using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
            /*scrollColor.Parent = flowLayout_Leaderboard;*/
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            Home.homeInstance = homeForm;
            homeForm.Show();
            this.Close();
            this.Dispose();
            homeForm = null;
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            while (PlayerCard.GameHistory.Count > 0) { 
                PlayerCard item = PlayerCard.GameHistory.Pop();
                HistoryUC card = new HistoryUC(item);
                flowLayoutPanel_GameHistory.Controls.Add(card);
                PlayerCard.GameHistoryTemporary.Push(item);
            }

            PlayerCard.ReturnToSender();
        }
    }
}
