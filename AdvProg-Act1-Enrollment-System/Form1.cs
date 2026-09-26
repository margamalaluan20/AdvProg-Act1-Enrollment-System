using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvProg_Act1_Enrollment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // SMART AUTO-CONNECT: Ikokonekta lahat, kasama na ang Submit at Clear!
            IkonekLahat(this);
        }

        private void IkonekLahat(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is DateTimePicker dtp) dtp.ValueChanged += Dtp_ValueChanged;
                if (c is ComboBox cmb) cmb.SelectedIndexChanged += Cmb_SelectedIndexChanged;

                // Hahanapin ang mga Buttons gamit ang Text nila
                if (c is Button btn)
                {
                    if (btn.Text.ToLower().Contains("submit")) btn.Click += BtnSubmit_Click;
                    if (btn.Text.ToLower().Contains("clear")) btn.Click += BtnClear_Click;
                }

                if (c.Controls.Count > 0) IkonekLahat(c);
            }
        }

        // ==========================================================
        // SUBMIT BUTTON LOGIC
        // ==========================================================
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Pagkuha ng mga values mula sa Form
            string firstName = KuninAngText(this, "txtFirstName");
            string middleName = KuninAngText(this, "txtMiddleName");
            string lastName = KuninAngText(this, "txtLastName");
            string fullName = $"{firstName} {middleName} {lastName}".Trim();

            string address = KuninAngText(this, "txtAddress");
            string dob = HanapinAngDOB(this);
            string age = KuninAngText(this, "txtAge") != "" ? KuninAngText(this, "txtAge") : "0";

            string gender = HanapinAngRadio(this, "rbMale", "rbFemale");
            string track = KuninAngText(this, "cmbTrack");
            string strand = KuninAngText(this, "cmbStrand");
            string grade = HanapinAngRadio(this, "rbGrade11", "rbGrade12");

            string subjects = HanapinAngCheckedItems(this, "clbSubjects");
            string bloodType = KuninAngText(this, "cmbBloodType");
            string needs = HanapinAngCheckedItems(this, "clbAccessibility");

            string contactPerson = KuninAngText(this, "txtContactPerson");
            string contactNumber = KuninAngText(this, "mtbContactNumber");

            // Pagbuo ng Final Output (Eksakto sa Picture)
            string result = "Personal Information\r\n\r\n";
            result += $"Full Name: {fullName}\r\n";
            result += $"Address: {address}\r\n";
            result += $"Date of Birth: {dob}\r\n";
            result += $"Age: {age}\r\n";
            result += $"Gender: {gender}\r\n\r\n";

            result += "Academic Information\r\n\r\n";
            result += $"Track/Strand: {track}/{strand}\r\n";
            result += $"Year Level: {grade}\r\n";
            result += $"Subjects Enrolled:\r\n{subjects}\r\n\r\n";

            result += "Health and Emergency Information\r\n\r\n";
            result += $"Bloodtype: {bloodType}\r\n";
            result += $"Accessibility Needs: {needs}\r\n\r\n";

            result += $"Contact Person: {contactPerson}\r\n";
            result += $"Contact Number: {contactNumber}";

            // Hanapin ang malaking TextBox at ilagay ang result
            TextBox outputBox = HanapinAngOutputBox(this);
            if (outputBox != null)
            {
                outputBox.Text = result;
            }
            else
            {
                MessageBox.Show("Hindi mahanap ang output box. Siguraduhing may TextBox ka sa loob ng Enrollment Details.");
            }
        }

        // ==========================================================
        // CLEAR BUTTON LOGIC
        // ==========================================================
        private void BtnClear_Click(object sender, EventArgs e)
        {
            LinisinAngLahat(this);
        }

        private void LinisinAngLahat(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb) tb.Clear();
                if (c is ComboBox cmb) cmb.SelectedIndex = -1;
                if (c is RadioButton rb) rb.Checked = false;
                if (c is CheckedListBox clb)
                {
                    for (int i = 0; i < clb.Items.Count; i++)
                        clb.SetItemChecked(i, false);
                }
                if (c is DateTimePicker dtp) dtp.Value = DateTime.Now;
                if (c is MaskedTextBox mtb) mtb.Clear();

                if (c.Controls.Count > 0) LinisinAngLahat(c);
            }
        }

        // ==========================================================
        // HELPER FUNCTIONS (Para mahanap ang mga controls)
        // ==========================================================
        private string KuninAngText(Control parent, string nameToFind)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.Name.ToLower().Contains(nameToFind.ToLower())) return c.Text;
                if (c.Controls.Count > 0)
                {
                    string found = KuninAngText(c, nameToFind);
                    if (found != "") return found;
                }
            }
            return "";
        }

        private string HanapinAngDOB(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is DateTimePicker dtp) return dtp.Value.ToString("MMMM dd, yyyy");
                if (c.Controls.Count > 0)
                {
                    string found = HanapinAngDOB(c);
                    if (found != "") return found;
                }
            }
            return "";
        }

        private string HanapinAngRadio(Control parent, string opt1, string opt2)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is RadioButton rb && rb.Checked)
                {
                    if (rb.Name.ToLower().Contains("male") || rb.Name.ToLower().Contains("female") || rb.Text.ToLower() == "male" || rb.Text.ToLower() == "female")
                        return rb.Text;
                    if (rb.Name.ToLower().Contains("11") || rb.Name.ToLower().Contains("12"))
                        return rb.Text;
                }
                if (c.Controls.Count > 0)
                {
                    string found = HanapinAngRadio(c, opt1, opt2);
                    if (found != "") return found;
                }
            }
            return "";
        }

        private string HanapinAngCheckedItems(Control parent, string name)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is CheckedListBox clb && clb.Name.ToLower().Contains(name.ToLower()))
                {
                    List<string> items = new List<string>();
                    foreach (var item in clb.CheckedItems) items.Add(item.ToString());
                    return string.Join(", ", items);
                }
                if (c.Controls.Count > 0)
                {
                    string found = HanapinAngCheckedItems(c, name);
                    if (found != "") return found;
                }
            }
            return "";
        }

        private TextBox HanapinAngOutputBox(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb && tb.Multiline) return tb;
                if (c.Controls.Count > 0)
                {
                    TextBox found = HanapinAngOutputBox(c);
                    if (found != null) return found;
                }
            }
            return null;
        }

        // ==========================================================
        // AGE, TRACK, STRAND LOGIC (Nandito pa rin!)
        // ==========================================================
        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            int age = DateTime.Today.Year - dtp.Value.Year;
            if (dtp.Value.Date > DateTime.Today.AddYears(-age)) age--;
            if (age < 0) age = 0;

            foreach (Control c in dtp.Parent.Controls)
            {
                if (c is TextBox tb && (tb.Name.ToLower().Contains("age") || tb.Enabled == false))
                    tb.Text = age.ToString();
            }
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox track = (ComboBox)sender;
            if (track.SelectedItem == null) return;
            string pinili = track.SelectedItem.ToString();

            if (pinili == "Academic" || pinili == "TVL")
            {
                ComboBox strandBox = null;
                foreach (Control c in track.Parent.Controls)
                {
                    if (c is ComboBox cmb && cmb != track) strandBox = cmb;
                }

                if (strandBox != null)
                {
                    strandBox.Items.Clear();
                    strandBox.Text = "";
                    if (pinili == "Academic") strandBox.Items.AddRange(new string[] { "STEM", "ABM", "GAS", "HUMSS" });
                    else if (pinili == "TVL") strandBox.Items.AddRange(new string[] { "ICT", "EIM", "FCS" });
                }
            }
        }

        // Lumang Empty Handlers
        private void txtAge_TextChanged(object sender, EventArgs e) { }
        private void cmbTrack_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void txtMiddleName_TextChanged(object sender, EventArgs e) { }
    }
}