using DataAccessLayer.Classes;
using LogicLayer.Entities;
using LogicLayer.LogicClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class AddScore : Form
    {
        //static TournamentDAL tournamentDAL = new TournamentDAL();
        DesktopForm desktopForm;
        TournamentAdministrator tournamentAdministrator;
        UserAdministrator userAdministrator;
        Match match;
        
        public AddScore(TournamentAdministrator tournamentAdministrator, UserAdministrator userAdministrator, Match match, DesktopForm desktopForm)
        {
            InitializeComponent();
            this.tournamentAdministrator = tournamentAdministrator;
            this.userAdministrator = userAdministrator;
            this.match = match; 
            this.desktopForm = desktopForm;
            lblP1Score.Text = $"First Player ({match.Player1.UserName}):";
            lblP2Score.Text = $"Second Player ({match.Player2.UserName}):";

        }

        private void btnConfirmScore_Click(object sender, EventArgs e)
        {
            int player1Score;
            int player2Score;
            bool tryP1Score = int.TryParse(tbP1Score.Text, out player1Score);
            bool tryP2Score = int.TryParse(tbP2Score.Text, out player2Score);
            
            
            if (tryP1Score && tryP2Score)
            {
                //match.Player1Score = player1Score;
                //match.Player2Score = player2Score;
                bool result = tournamentAdministrator.AddMatchScore(match,player1Score,player2Score);
                if (!result)
                {
                    
                    MessageBox.Show("Incorrect Score");
                }
                else
                {
                    if (player1Score>player2Score)
                    {
                        userAdministrator.AddAWinToAPlayer(match.Player1);
                        userAdministrator.AddALostToAPlayer(match.Player2);
                    }
                    else
                    {
                        userAdministrator.AddAWinToAPlayer(match.Player2);
                        userAdministrator.AddALostToAPlayer(match.Player1);
                    }
                    desktopForm.UpdateMatchList();
                    MessageBox.Show("Succesfully Added");
                }
            }
            else
            {
                MessageBox.Show("Pls fill scores correct format");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();            
            desktopForm.Show();            
        }

        private void AddScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            desktopForm.Show();
        }
    }
}
