using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NishantGame
{
   public class Nishant
   {  
        int Bullet;
        public void LoadingFunc() //loading the gun
        {
            Bullet = 6;
        }

        public int SpinFunc()
        {
            Random rand = new Random();
            Bullet = rand.Next(1, 7); //setting a range
            return Bullet;
            //chamber to go to a new place from 1 to 6 (which should be 7)

        }
        int chances = 4;
        public int ShootingAwayFunc()
        {            //if user will get 1 chance come message user is dead!
            if (Bullet == 1)
            {
                
                MessageBox.Show("You are dead, do you want to try Again");
                Application.Restart();
            }

            else

            {
                chances--;
                Bullet--;
                //if chances of shooting at your head is zero,
                if (chances == 0)
                {
                    MessageBox.Show("You win!!! Congrats! Do you want to try again?");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Try your luck.. ");
                }
            }
            return chances;
        }


        int chancesAway = 2;


        public int ShootingAwayFunc2()
        {
            if (Bullet == 1)
            {
                //tell the user you died!
                MessageBox.Show("You Safe");
            }
            else
            {
                chancesAway--;
                Bullet--;
                //if chances are zero tell him you are dead else tell him keep playing
                if (chancesAway == 0)
                {
                    MessageBox.Show("You have lost all chances of survival, do you want to play again?", "Game Over");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("All the best!! Last chance to try your luck");
                }
            }

            return chancesAway;
        }

    }
}

    



   

