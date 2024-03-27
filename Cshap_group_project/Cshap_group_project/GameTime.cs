using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cshap_group_project
{
    public partial class GameTime : Form
    {


        private Timer gameTimer;
        private DateTime startTime;

        public GameTime()
        {
            InitializeComponent();
            gameTimer = new Timer();
            gameTimer.Interval = 1000; // 1초마다 경과 시간 업데이트
            gameTimer.Tick += GameTimer_Tick;

            startTime = DateTime.Now;
            gameTimer.Start();

            Game_Time.ForeColor = Color.HotPink;
            Game_Time.BackColor = Color.Black;

            



        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime;
            string elapsedTime = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}";
            Game_Time.Text = elapsedTime;
        }


    }
}
