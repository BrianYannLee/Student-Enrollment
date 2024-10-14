using System;

namespace Student_Enrollment
{
    public partial class Form1 : Form
    {
        #region Constructor and Setup

        // Form Constructor
        public Form1()
        {
            InitializeComponent();
            Setup(); // Initialize UI elements
        }

        // Setup initial state of UI components
        private void Setup()
        {
            cbDegree.Items.AddRange(new object[] { "", "AAS-CSI", "AAS-NW", "AAS-AI", "AAS-BA", "AAS-CS" });
            lNameError.Visible = false;
            lPhoneError.Visible = false;
            lDegreeError.Visible = false;
        }

        #endregion

        #region Helper Methods

        // Reset input fields and error labels
        private void Reset()
        {
            lNameError.Visible = false;
            lPhoneError.Visible = false;
            lDegreeError.Visible = false;

            tbName.Text = "";
            tbPhone.Text = "";
            cbDegree.Text = "";
        }

        // Update text boxes with selected item's data
        private void UpdateTextBox(int index)
        {
            if (index >= 0 && index < lvDisplay.Items.Count) // Ensure index is valid
            {
                var selectedItem = lvDisplay.Items[index];
                tbName.Text = selectedItem.Text;
                tbPhone.Text = selectedItem.SubItems[1].Text;
                cbDegree.Text = selectedItem.SubItems[2].Text;
            }
        }

        // Get the index of the currently selected item in the ListView
        private int GetSelectedIndex()
        {
            if (lvDisplay.SelectedItems.Count > 0)
            {
                return lvDisplay.SelectedItems[0].Index;
            }
            return -1; // No item selected
        }

        // Select an item at the given index and update UI accordingly
        private void SelectItem(int index)
        {
            if (index >= 0 && index < lvDisplay.Items.Count) // Ensure index is within bounds
            {
                lvDisplay.SelectedItems.Clear(); // Deselect all items

                lvDisplay.Items[index].Focused = true;
                lvDisplay.Items[index].Selected = true;
                lvDisplay.EnsureVisible(index); // Ensure the item is visible

                UpdateTextBox(index); // Update the text fields
            }
        }

        #endregion

        #region Event Handlers

        // Handle Enroll button click
        private void bEnroll_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
                lNameError.Visible = true;
            if (tbPhone.Text == "")
                lPhoneError.Visible = true;
            if (cbDegree.Text == "")
                lDegreeError.Visible = true;

            // If all inputs are valid, add item to ListView and reset fields
            if (tbName.Text != "" && tbPhone.Text != "" && cbDegree.Text != "")
            {
                ListViewItem item = new ListViewItem(tbName.Text);
                item.SubItems.Add(tbPhone.Text);
                item.SubItems.Add(cbDegree.Text);
                lvDisplay.Items.Add(item);

                Reset(); // Reset input fields
            }
        }

        // Select the first item in the ListView
        private void bFirst_Click(object sender, EventArgs e)
        {
            if (lvDisplay.Items.Count > 0) // Ensure there's at least one item
            {
                SelectItem(0); // Select the first item
            }
        }

        // Move to the previous item in the ListView
        private void bPrevious_Click(object sender, EventArgs e)
        {
            int currentIndex = GetSelectedIndex();
            if (currentIndex > 0) // Ensure not at the first item
            {
                SelectItem(currentIndex - 1); // Move to the previous item
            }
        }

        // Move to the next item in the ListView
        private void bNext_Click(object sender, EventArgs e)
        {
            int currentIndex = GetSelectedIndex();
            if (currentIndex != -1 && currentIndex < lvDisplay.Items.Count - 1) // Ensure not at the last item
            {
                SelectItem(currentIndex + 1); // Move to the next item
            }
        }

        // Select the last item in the ListView
        private void bEnd_Click(object sender, EventArgs e)
        {
            if (lvDisplay.Items.Count > 0) // Ensure there are items in the ListView
            {
                SelectItem(lvDisplay.Items.Count - 1); // Select the last item
            }
        }

        #endregion
    }
}
