﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace Presentation_Layer
{
	public partial class frmMain : Form
	{
		//variables
		//private _player1Score = 0;
		//private _player2Score = 0;
		private ResourceManager _rm = new ResourceManager(
			"Presentation_Layer.CardResources", Assembly.GetExecutingAssembly());


		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			resetCardDisplay();
		}

		private void resetCardDisplay()
        {
			//background image of the card
			pickCard1.Image = (Image)_rm.GetObject("CardBack");
			pickCard2.Image = (Image)_rm.GetObject("CardBack");
			pickCard3.Image = (Image)_rm.GetObject("CardBack");
			pickCard4.Image = (Image)_rm.GetObject("CardBack");
			pickCard5.Image = (Image)_rm.GetObject("CardBack");
			pickCard6.Image = (Image)_rm.GetObject("CardBack");
			pickCard7.Image = (Image)_rm.GetObject("CardBack");

			//label above cards, blank in this state
			lblCard1.Text = "";
			lblCard2.Text = "";
			lblCard3.Text = "";
			lblCard4.Text = "";
			lblCard5.Text = "";
			lblCard6.Text = "";
			lblCard7.Text = "";

			//Making sure the check box's are not checked at the start
			chkCard1.Checked = false;
			chkCard2.Checked = false;


			//Do not let people click buttons when they shouldnt
			btnDrawCards.Enabled = false;
			btnDealNewHand.Enabled = true;
			btnScoreHand.Enabled = false;
        }

        private void btnScoreHand_Click(object sender, EventArgs e)
        {

        }

        private void btnDealNewHand_Click(object sender, EventArgs e)
        {

        }

        private void btnDrawCards_Click(object sender, EventArgs e)
        {

        }
    }
}
