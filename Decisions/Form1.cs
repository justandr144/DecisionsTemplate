using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void driveButton_Click(object sender, EventArgs e)
        {
            /* Create an if statement to check age and display a messaage
               stating "You can drive now" if age is 16. If not 16 then display,
               "You are not 16".
            */
            int age;
            age = Convert.ToInt32(ageInput.Text);


            if (age >= 16)
            {
                driveOutput.Text = "You are old enough to drive";
            }
            else
            {
                driveOutput.Text = "You are not 16";
            }
        }

        private void ageButton_Click(object sender, EventArgs e)
        {
            /* Create a variable to hold a person's age. Then use that variable
               to determine if the person is old enough to vote. Display an
               appropriate message based on whether they can or can't vote            
             */
            int age;
            age = Convert.ToInt32(ageInput.Text);

            if (age >= 18)
            {
                voteOutput.Text = "You are old enough to vote";
            }
            else
            {
                voteOutput.Text = "You are not old enough to vote";
            }

        }

        private void workButton_Click(object sender, EventArgs e)
        {
            /* Create a program that determines how many overtime hours 
               an employee has worked. Any hours over 40 is considered overtime. 
               Make sure that your output matches the sample output below exactly.
             
               Sample Output for 15 hours:
               You worked 15 hours

               Sample output for 45 hours:
               You worked 40 hours plus 5 hours overtime

             */
            int hoursWorked;
            int overtimeWorked;
            hoursWorked = Convert.ToInt32(hoursInput.Text);
            overtimeWorked = hoursWorked - 40;

            if (hoursWorked <= 40)
            {
                workOutput.Text = $"You worked {hoursWorked} hours";
            }
            else
            {
                workOutput.Text = $"You worked 40 hours plus {overtimeWorked} hours overtime";
            }
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            /* Create a program that determines the max value between 2 values 
               inputted by the user. The output should match the following:

               Sample output for inputs 34, 12
               The max value is: 34

               Sample output for inputs 22, 77
               The max value is: 77
            */
            int firstInput;
            int secondInput;
            firstInput = Convert.ToInt32(num1Input.Text);
            secondInput = Convert.ToInt32(num2Input.Text);

            if (firstInput > secondInput)
            {
                maxOutput.Text = $"The max value is: {firstInput}";
            }

            if (firstInput < secondInput)
            {
                maxOutput.Text = $"The max value is: {secondInput}";
            }

            if (firstInput == secondInput)
            {
                maxOutput.Text = $"The max value is: {firstInput}";
            }
        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            /* Create a program that determines if an entered year is a 
               leap year. The output should match the following:

               Sample output for inputs 2002
               2002 is not a leap year

               Sample output for inputs 2016
               2016 is a leap year
            */
            double year;
            double divisible;
            int check;

            year = Convert.ToDouble(yearInput.Text);
            divisible = year / 4;
            check = Convert.ToInt32(divisible);

            if (divisible == check)
            {
                yearOutput.Text = $"{year} is a leap year";
            }
            else
            {
                yearOutput.Text = $"{year} is not a leap year";
            }

            /* if (year % 4 == 0)
             * {
             * yearOutput.Text = $"{year} is a leap year";
             * }
             * else
             * {
             * yearOutput.Text = $"{year} is not a leap year";
             * }
             */
        }
    }
}
