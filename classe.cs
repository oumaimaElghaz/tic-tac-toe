using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace TIC_TAC_TOE
{
    class classe
    {
        bool turn = true;
        int turn_count = 0;
        bool there_is_winner = false;
        public void entrer()
        {
            Button b ;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "X";
                }
                else
                    b.Text = "O";
            }
        }
        public void leave()
        {
            Button b ;
            if (b.Enabled)
            {
                b.Text = "";
            }

        }
        public void cliquer()
        {
            Button b ;
            if (turn)
            {
                b.Text = "X";
            }
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            checkforWinner();
        }
        public void checkforWinner()
        {
            Button button1, button2, button3, button4, button5, button6, button7, button8, button9;
            
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
                there_is_winner = true;
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                there_is_winner = true;
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                there_is_winner = true;
            //vertical check
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                there_is_winner = true;
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                there_is_winner = true;
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))

                there_is_winner = true;
            //diagonal check

            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
                there_is_winner = true;
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button7.Enabled))
                there_is_winner = true;
        }
        public void compteur()
        {
            if (there_is_winner)

            {
                disablebuttons();
                string winner = "";
                if (turn)
                {
                    Label O_Win_count, X_Win_count, draw_count;
                    
                    winner = "O";
                    O_Win_count.Text = (Int32.Parse(O_Win_count.Text + 1).ToString());
                }
                else
                    winner = "X";
                X_Win_count.Text = (Int32.Parse(X_Win_count.Text + 1).ToString());
                ; MessageBox.Show(winner + "you win");
            }
            else
            {
                if (turn_count == 9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text + 1).ToString());
                    MessageBox.Show("Draw", "Bummer!");
                }
            }
        }
        public void disablebuttons()
        {
            try
            {
                foreach (Control c in Control)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }

        }
        public void ResetGame(Form1 f)
        {  
            f.Refresh();
        }
    }

}
