using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        string calculation = "";
        string currentAction = "";
        string actionCalc = "";

        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }



        private void Form_KeyDown(object sender, KeyEventArgs e)
        {

            Button btn = new Button();

            // btn.Text = e.KeyCode.ToString();

            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                btn.Text = e.KeyCode.ToString().Remove(0, 1);
            }
            else if(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                btn.Text = e.KeyCode.ToString().Remove(0, 6);

            }

            if (e.KeyCode == Keys.Back) btn.Text = "←";
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus) btn.Text = "+";
            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus) btn.Text = "-";
            if (e.KeyCode == Keys.Multiply) btn.Text = "x";
            if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion) btn.Text = "/";
            if (e.KeyCode == Keys.C) btn.Text = "C";
            if (e.KeyCode == Keys.Enter) btn.Text = "=";


            onCalcBtnClick(btn, e);
        }

        private void onCalcBtnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            bool actionCalcEmpty = string.IsNullOrEmpty(actionCalc);
            bool isAction = string.IsNullOrEmpty(currentAction);

            switch (btn.Text)
            {
                // Equations
                case "+":
                    if (string.IsNullOrEmpty(calculation)) return;
                    if (actionCalcEmpty)
                    {
                        currentAction = "+";
                        CalcLabel.Text = "+";
                        break;
                    }
                    else
                    {
                        double sum = Convert.ToDouble(calculation) + Convert.ToDouble(actionCalc);

                        CalcLabel.Text = Convert.ToString(sum);
                        calculation = Convert.ToString(sum);
                        actionCalc = "";

                    }
                    break;

                case "-":
                    if (string.IsNullOrEmpty(calculation)) return;
                    if (actionCalcEmpty)
                    {
                        currentAction = "-";
                        CalcLabel.Text = "-";
                        break;
                    }
                    else
                    {

                        double sub = Convert.ToDouble(calculation) - Convert.ToDouble(actionCalc);

                        CalcLabel.Text = Convert.ToString(sub);
                        calculation = Convert.ToString(sub);
                        actionCalc = "";

                    }

                    break;

                case "x":
                    if (string.IsNullOrEmpty(calculation)) return;
                    if (actionCalcEmpty)
                    {
                        currentAction = "x";
                        CalcLabel.Text = "x";
                        break;
                    }
                    else
                    {
                        double mult = Convert.ToDouble(calculation) * Convert.ToDouble(actionCalc);

                        CalcLabel.Text = Convert.ToString(mult);
                        calculation = Convert.ToString(mult);
                        actionCalc = "";

                    }
                    break;

                case "/":
                    if (string.IsNullOrEmpty(calculation)) return;
                    if (actionCalcEmpty)
                    {
                        currentAction = "/";
                        CalcLabel.Text = "/";
                        break;
                    }
                    else
                    {
                        if(Convert.ToDouble(calculation) == 0 || Convert.ToDouble(actionCalc) == 0 )
                        {
                            CalcLabel.Text = "Cannot divide by 0";
                            actionCalc = "";
                            calculation = "";
                            currentAction = "";
                        }
                        else
                        {
                        double div = Convert.ToDouble(calculation) / Convert.ToDouble(actionCalc);

                        CalcLabel.Text = Convert.ToString(div);
                        calculation = Convert.ToString(div);
                        actionCalc = "";
                        }
                       

                    }
                    break;

                case "=":
                    bool filled = true;
                    if (string.IsNullOrEmpty(calculation) || string.IsNullOrEmpty(actionCalc)) filled = false;

                    double result = 0;

                    switch (currentAction)
                    {
                        case "+":
                            if (!filled) return;
                                result = Convert.ToDouble(calculation) + Convert.ToDouble(actionCalc);
                            break;
                        case "-":
                            if (!filled) return;
                            result = Convert.ToDouble(calculation) - Convert.ToDouble(actionCalc);
                            break;
                        case "x":
                            if (!filled) return;
                            result = Convert.ToDouble(calculation) * Convert.ToDouble(actionCalc);
                            break;
                        case "/":
                            if (Convert.ToDouble(calculation) == 0 || Convert.ToDouble(actionCalc) == 0)
                            {
                                CalcLabel.Text = "Cannot divide by 0";
                                actionCalc = "";
                                calculation = "";
                                currentAction = "";
                                return;
                            }
                            else
                            {
                                result = Convert.ToDouble(calculation) / Convert.ToDouble(actionCalc);
                            }

                            break;
                    }

                    currentAction = "";

                    CalcLabel.Text = Convert.ToString(result);
                    actionCalc = "";
                    calculation = "";
                    break;

                // Calculator Actions
                case "←":
                    if (string.IsNullOrEmpty(currentAction))
                    {
                        if (string.IsNullOrEmpty(calculation)) return;
                        calculation = calculation.Remove(calculation.Length - 1, 1);
                        CalcLabel.Text = calculation;
                        
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(actionCalc)) return;
                        actionCalc = actionCalc.Remove(actionCalc.Length - 1, 1);
                        CalcLabel.Text = actionCalc;
                    }
                    break;

                case "√":
                    if (string.IsNullOrEmpty(calculation)) return;
                    double squareRoot = Math.Sqrt(Convert.ToDouble(calculation));
                    CalcLabel.Text = $"√{calculation} = {squareRoot}";
                    currentAction = "";
                    calculation = squareRoot.ToString();
                    break;

                case "C":
                    actionCalc = "";
                    calculation = "";
                    currentAction = "";
                    CalcLabel.Text = "Enter number:";
                    break;

                case "CE":
                    if (string.IsNullOrEmpty(currentAction))
                    {
                        calculation = "";
                        CalcLabel.Text = "";
                    }
                    else
                    {
                        actionCalc = "";
                        CalcLabel.Text = "";
                    }
                    break;

                default:
                    CalcLabel.Text = "";

                    if (isAction)
                    {
                        calculation += btn.Text;

                        foreach (var text in calculation)
                        {
                            CalcLabel.Text += text;
                        }
                        break;
                    }
                    else
                    {
                        actionCalc += btn.Text;

                        foreach (var text in actionCalc)
                        {
                            CalcLabel.Text += text;
                        }
                        break;
                    }

            }
        }

    }

}