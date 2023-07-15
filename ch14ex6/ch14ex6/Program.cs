using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*************************************************************************/
/* Program Name:     Ch14Ex6.cs                                          */
/* Date:             03/22/2022                                     	 */
/* Programmer:       Miranda Morris                                 	 */
/* Class:            CSCI 234                                            */
/*                                                    				     */
/* Program Description: The purpose of this program is to convert a temp */
/* that is in Fahrenheit to Celsius.                                     */
/*                                                                       */
/* Input: a temp in Fahrenheit									         */
/*                                                                       */
/* Output: the same inputted temp converted to Celsius                   */
/*                                                                       */
/* Givens: Celsius = (5/9) * (Fahrenheit - 32)						     */
/*                                                                       */
/* Testing Data:                                                         */
/*                                                                       */
/* List the Testing Input Data: 50,                                      */
/*                              90,                                      */
/*                              70,                                      */
/*                                                                       */
/* List the Testing Output Data: 10,                                     */
/*                               32.22,                                  */
/*                               21.11                                   */
/*                                                                       */
/*************************************************************************/

namespace ch14ex6
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
