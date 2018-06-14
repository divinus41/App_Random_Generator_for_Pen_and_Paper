using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RandomGenerator
{
    public partial class FormMain : Form
    {
        // Value types
        private int addDiceTypeCount = 1;
        private int multiplicatorLocationY = 35;
        private int offset = 35;
        private int diceTypes = 1;
        private int optionsAmount = 0; // for decision helper
        private ComboBox comboBox;
        private TextBox textBox;
        private ListBox listBox;

        public FormMain()
        {
            InitializeComponent();

            // Add number zero for the current widgets.
            ComboBoxDiceSides.Name += 0;
            TextboxDiceAmount.Name += 0;
            ListboxResultOutput.Name += 0;
        }

        private void ButtonAddDiceType_Click(object sender, EventArgs e)
        {
            ButtonNewLocations(offset);

            // Set the Settings for new widgets.
            comboBox = new ComboBox
            {
                Name = "ComboBoxDiceSides" + Convert.ToString(addDiceTypeCount),
                BackColor = ComboBoxDiceSides.BackColor,
                Font = new Font(ComboBoxDiceSides.Font.Name, ComboBoxDiceSides.Font.Size),
                Text = ComboBoxDiceSides.Text,
                Size = ComboBoxDiceSides.Size,
                Location = new Point(ComboBoxDiceSides.Location.X, ComboBoxDiceSides.Location.Y + multiplicatorLocationY)
            };

            textBox = new TextBox
            {
                Name = "TextboxDiceAmount" + Convert.ToString(addDiceTypeCount),
                BackColor = TextboxDiceAmount.BackColor,
                BorderStyle = TextboxDiceAmount.BorderStyle,
                Font = new Font(TextboxDiceAmount.Font.Name, 16F),
                TextAlign = TextboxDiceAmount.TextAlign,
                Anchor = TextboxDiceAmount.Anchor,
                Size = TextboxDiceAmount.Size,
                Location = new Point(TextboxDiceAmount.Location.X, ComboBoxDiceSides.Location.Y + multiplicatorLocationY)
            };

            listBox = new ListBox
            {
                Name = "ListboxResultOutput" + Convert.ToString(addDiceTypeCount),
                BackColor = ListboxResultOutput.BackColor,
                ForeColor = ListboxResultOutput.ForeColor,
                BorderStyle = ListboxResultOutput.BorderStyle,
                Font = new Font(ListboxResultOutput.Font.Name, ListboxResultOutput.Font.Size),
                Size = new Size(ListboxResultOutput.Size.Width, 30),
                Location = new Point(ListboxResultOutput.Location.X, ListboxResultOutput.Location.Y + multiplicatorLocationY)
            };

            // Add items for the 'newComboBox'.
            for (int i = 0; i < ComboBoxDiceSides.Items.Count; i++)
                comboBox.Items.Add(ComboBoxDiceSides.Items[i]);

            // Add widgets.
            Controls.Add(comboBox);
            Controls.Add(textBox);
            Controls.Add(listBox);

            // Set new moving position for widgets.
            addDiceTypeCount++;
            multiplicatorLocationY += offset;

            // By one dice type, disable remove button. By four dice type, disable add button. Otherwise enable all buttons.
            diceTypes++;

            if (diceTypes == 1)
                ButtonRemoveDiceType.Enabled = false;
            else if (diceTypes == 5)
                ButtonAddDiceType.Enabled = false;
            else
            {
                ButtonRemoveDiceType.Enabled = true;
                ButtonAddDiceType.Enabled = true;
            }
        }

        private void ButtonRemoveDiceType_Click(object sender, EventArgs e)
        {
            // Declare variables
            int allComboboxes = 0;
            int allTextboxes = 0;
            int allListboxes = 0;
            int currentCombobox = 0;
            int currentTextbox = 0;
            int currentListbox = 0;

            // Count all widgets from the current window.
            foreach (Control item in Controls)
            {
                if (item.GetType() == typeof(ComboBox))
                    allComboboxes++;
                else if (item.GetType() == typeof(TextBox))
                    allTextboxes++;
                else if (item.GetType() == typeof(ListBox))
                    allListboxes++;
            }

            // Remove Last ComboBox and ListBox.
            foreach (Control item in Controls)
            {
                if (item.GetType() == typeof(ComboBox))
                {
                    currentCombobox++;

                    if (currentCombobox == allComboboxes)
                    {
                        Controls.Remove(item);
                        item.Dispose();
                    }
                }
                else if (item.GetType() == typeof(ListBox))
                {
                    currentListbox++;

                    if (currentListbox == allListboxes)
                    {
                        Controls.Remove(item);
                        item.Dispose();
                    }
                }
            }

            // Remove Last TextBox.
            foreach (Control item in Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    currentTextbox++;

                    if (currentTextbox == allTextboxes)
                    {
                        Controls.Remove(item);
                        item.Dispose();
                    }
                }
            }

            // Decrement amount of dice types.
            addDiceTypeCount--;
            multiplicatorLocationY -= offset;

            // By one dice type, disable remove button, otherwise enable all buttons.
            diceTypes--;

            if (diceTypes == 1)
                ButtonRemoveDiceType.Enabled = false;
            else
            {
                ButtonRemoveDiceType.Enabled = true;
                ButtonAddDiceType.Enabled = true;
            }

            ButtonNewLocations(-offset);
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine("button clicked");
            //for the number of different diceTypes
            //HIER WIRD NOCH DIE VARIABLE VON FETHI BENOETIGT (statt 1)
            int diceTypeCounter = addDiceTypeCount;
            //for the number of dices of one specific type
            TextBox diceAmountBox = new TextBox();
            //for the type of the dice
            ComboBox diceTypeBox = new ComboBox();
            //for the output
            ListBox resultBox = new ListBox();
            Random random = new Random();

            //iterate through the types
            for (int i = 0; i < diceTypeCounter; i++)
            {
                //Debug.WriteLine("outer loop");
                //find instances of the boxes and save them as variables
                if (this.Controls.ContainsKey("ComboBoxDiceSides" + i.ToString()))
                {
                    diceTypeBox = this.Controls["ComboBoxDiceSides" + i.ToString()] as ComboBox;
                }
                if (this.Controls.ContainsKey("TextBoxDiceAmount" + i.ToString()))
                {
                    diceAmountBox = this.Controls["TextBoxDiceAmount" + i.ToString()] as TextBox;
                }
                if (this.Controls.ContainsKey("ListboxResultOutput" + i.ToString()))
                {
                    resultBox = this.Controls["ListboxResultOutput" + i.ToString()] as ListBox;
                    resultBox.Items.Clear();
                }
                if (diceAmountBox.Text != "")
                {
                    Debug.WriteLine(diceAmountBox.Text);
                    //fill result box with random values, depending on diceType and diceAmount
                    for (int j = 0; j < Convert.ToInt32(diceAmountBox.Text); j++)
                    {
                        if (diceTypeBox.Text != "Dice side")
                        {
                            //Debug.WriteLine("inner loop");
                            resultBox.Items.Add(random.Next(1, (Convert.ToInt32(diceTypeBox.Text) + 1)));

                        }
                        else
                        {
                            resultBox.Items.Add("Please select a dice kind");
                        }

                    }
                }
                else
                {
                    resultBox.Items.Add("Please enter an amount of dices");
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Random flip = new Random();
            int coinflip = flip.Next(0, 2);

            CoinflipResultLabel.Text = "Flipping...";
            await Task.Delay(1000);

            if (coinflip == 0)
            {
                CoinflipResultLabel.Text = "Heads";
            }
            else if (coinflip == 1)
            {
                CoinflipResultLabel.Text = "Tails";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EnterOptionTextbox.Text != "")
            {
                OptionsListBox.Items.Add(EnterOptionTextbox.Text);
                optionsAmount++;
                EnterOptionTextbox.Text = "";
            }

            EnterOptionTextbox.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OptionsListBox.Items.Clear();
            optionsAmount = 0;
        }

        private async void Decide_Click(object sender, EventArgs e)
        {
            if (optionsAmount > 0)
            {
                DecisionResultLabel.Text = "Flipping...";
                await Task.Delay(1000);
                Random choose = new Random();
                int choice = choose.Next(0, (optionsAmount));
                DecisionResultLabel.Text = Convert.ToString(OptionsListBox.Items[choice]);
            }
            else
            {
                DecisionResultLabel.Text = "Enter some options first";
            }
        }

        private void ButtonNewLocations(int offset)
        {
            ButtonAddDiceType.Location = new Point(ButtonAddDiceType.Location.X, ButtonAddDiceType.Location.Y + offset);
            ButtonRemoveDiceType.Location = new Point(ButtonRemoveDiceType.Location.X, ButtonRemoveDiceType.Location.Y + offset);
            ButtonResult.Location = new Point(ButtonResult.Location.X, ButtonResult.Location.Y + offset);
        }

        private void EnterOptionTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                button1_Click(sender, e);
        }
    }
}